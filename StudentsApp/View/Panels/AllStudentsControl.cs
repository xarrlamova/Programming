using StudentsApp.Model;
using StudentsApp.Model.Classes;
using StudentsApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace StudentsApp.View.Panels
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий данные о студентах.
    /// </summary>
    public partial class AllStudentsControl : UserControl
    {
        /// <summary>
        /// Список студентов.
        /// </summary>
        private List<Student> _students = new();

        /// <summary>
        /// Текущий студент.
        /// </summary>
        private Student _currentStudent = new Student();
        
        public AllStudentsControl()
        {
            InitializeComponent();
            _students = StudentRepository.Load();
            _students = _students.OrderBy(_currentStudent => _currentStudent.FullName)
                    .ToList();
            StudentsListBox.Items.AddRange(_students.ToArray());

            FacultyComboBox.Items.AddRange(Enum.GetNames(typeof(Faculty)));
            Dictionary<string, EducationForm> _educationForm = new Dictionary<string, EducationForm>()
            {
                {"Очная", EducationForm.Fulltime},
                {"Заочная", EducationForm.Correspondence},
                {"Дистанционная", EducationForm.Distance},
                {"Вечерняя", EducationForm.Evening},
            };

            EducationFormComboBox.DataSource = new BindingSource(_educationForm, null);
            EducationFormComboBox.DisplayMember = "Key";
            EducationFormComboBox.Text = null;

            Dictionary<string, Faculty> _faculty = new Dictionary<string, Faculty>()
            {
                {"Факультет систем управления", Faculty.AutomatedControlSystems },
                {"Факультет вычислительных систем", Faculty.ComputerSystems },
                {"Факультет электронной техники", Faculty.ElectronicEngineering },
                {"Факультет инновационных технологий", Faculty.Innovation },
                {"Факультет безопасности", Faculty.Security },
                {"Радиоконструкторский факультет", Faculty.RadioDisign },
                {"Радиотехнический факультет", Faculty.RadioEngineering },
                {"Экономический факультет", Faculty.Economic },
                {"Гуманитарный факультет", Faculty.Humanitarian },
                {"Юридический факультет", Faculty.Law },
                {"Вечерний факультет", Faculty.Evening },
                {"Аспирантура", Faculty.Graduate }
            };

            FacultyComboBox.DataSource = new BindingSource(_faculty, null);
            FacultyComboBox.DisplayMember = "Key";
            FacultyComboBox.Text = null;
        }

        /// <summary>
        /// Добавляет данные о студентах в список при нажатии на кнопку.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearInfo();
            TextAndComboBoxesBackColorWhite();
            TextAndComboBoxesSwitch(true);
            FullNameTextBox.ReadOnly = false;
            GroupTextBox.ReadOnly = false;

            ApplyAddButton.Visible = true;
            EditButton.Enabled = false;
            CancelButton.Visible = true;
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
            StudentsListBox.Enabled = false;
            ApplyChangesButton.Visible = false;

            var id = StudentRepository.GetId();
            IdTextBox.Text = Convert.ToString(id + 1);
        }

        /// <summary>
        /// Позволяет редактировать данные о студенте при нажатии на кнопку.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            TextAndComboBoxesSwitch(true);
            ApplyChangesButton.Visible = true;
            ApplyAddButton.Visible = false;
            CancelButton.Visible = true;
            FullNameTextBox.ReadOnly = false;
            GroupTextBox.ReadOnly = false;
            FacultyComboBox.Enabled = true;
            EducationFormComboBox.Enabled = true;
            FullNameTextBox.BackColor = Color.White;
            GroupTextBox.BackColor = Color.White;

        }

        /// <summary>
        /// Сохраняет внесенные изменения о студенте при нажатии на кнопку.
        /// </summary>
        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            _currentStudent.FullName = FullNameTextBox.Text;
            _currentStudent.Group = GroupTextBox.Text;
            _currentStudent.Faculty = FacultyComboBox.Text;
            _currentStudent.EducationForm = EducationFormComboBox.Text;

            if (FacultyComboBox.Text != "" && EducationFormComboBox.Text != "")
            {
                var id = StudentRepository.GetId();
                StudentRepository.Save(_students, id);
                TextAndComboBoxesSwitch(false);
                ApplyChangesButton.Visible = false;
                CancelButton.Visible = false;
                AddButton.Enabled = true;
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
  
                SortAndAddToListBox();
                StudentsListBox.SelectedItem = _currentStudent;
            }
            else if (FacultyComboBox.Text == "")
            {
                MessageBox.Show("Выберите факультет в выпадающем списке факультет.");
            }
            else if (EducationFormComboBox.Text == "")
            {
                MessageBox.Show("Выберите форму обучения в выпадающем списке форма обучения.");
            }

        }

        /// <summary>
        /// Удаляет данные о выбранном студенте.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = StudentsListBox.SelectedIndex;

            if (StudentsListBox.Items.Count > 0 && StudentsListBox.SelectedIndex >= 0)
            {
                _currentStudent = _students[selectedIndex];
                _students.RemoveAt(selectedIndex);
                _students.Remove(_currentStudent);
                var id = StudentRepository.GetId();
                StudentRepository.Save(_students, id);

                ClearInfo();
                IdTextBox.Clear();
                TextAndComboBoxesBackColorWhite();
                TextAndComboBoxesSwitch(false);
                SortAndAddToListBox();

                if(StudentsListBox.Items.Count == 0)
                {
                    EditButton.Enabled = false;
                    DeleteButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Проверяет и сохраняет добавленную информацию о студенте.
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            string fullName = FullNameTextBox.Text;
            string group = GroupTextBox.Text;
            string faculty = FacultyComboBox.Text;
            string educationForm = EducationFormComboBox.Text;
            int id = StudentRepository.GetId()+1;
            
            if (!string.IsNullOrEmpty(FacultyComboBox.Text) && !string.IsNullOrEmpty(EducationFormComboBox.Text) 
                && !string.IsNullOrEmpty(GroupTextBox.Text))
            {
                _currentStudent = new Student(fullName, group, faculty, educationForm, id);
                _students.Add(_currentStudent);

                StudentRepository.Save(_students, id);
                SortAndAddToListBox();
                IdTextBox.Text = Convert.ToString(_currentStudent.Id);
                TextAndComboBoxesSwitch(false);
                ApplyAddButton.Visible = false;
                CancelButton.Visible = false;
                AddButton.Enabled = true;
                StudentsListBox.Enabled = true;
                DeleteButton.Enabled = false;
                StudentsListBox.SelectedItem = _currentStudent;
            }
            else if (string.IsNullOrEmpty(GroupTextBox.Text))
            {
                MessageBox.Show("Введите номер группы в текстовом поле группа.");
            }
            else if(string.IsNullOrEmpty(FacultyComboBox.Text))
            {
                MessageBox.Show("Выберите факультет в выпадающем списке факультет.");
            }
            else if (string.IsNullOrEmpty(EducationFormComboBox.Text))
            {
                MessageBox.Show("Выберите форму обучения в выпадающем списке форма обучения.");
            }
        }

        /// <summary>
        /// Удаляет внесенные изменения, очищает формы при нажатии на кнопку.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearInfo();
            IdTextBox.Clear();
            TextAndComboBoxesSwitch(false);
            TextAndComboBoxesBackColorWhite();
            ApplyAddButton.Visible = false;
            ApplyChangesButton.Visible = false;
            CancelButton.Visible = false;
            AddButton.Enabled = true;
            StudentsListBox.Enabled = true;
            int currentIndex = StudentsListBox.SelectedIndex;
            if (currentIndex == -1)
            {
                return;
            }

            _currentStudent = _students[currentIndex];
            FullNameTextBox.Text = _currentStudent.FullName;
            IdTextBox.Text = Convert.ToString(_currentStudent.Id);
            GroupTextBox.Text = _currentStudent.Group;
            FacultyComboBox.Text = _currentStudent.Faculty;
            EducationFormComboBox.Text = _currentStudent.EducationForm;
        }

        /// <summary>
        /// Открывает данные о выбранном студенте при выборе определенного элемента.
        /// </summary>
        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
            if (StudentsListBox.SelectedIndex == -1)
            {
                EditButton.Enabled = false;
            }

            int currentIndex = StudentsListBox.SelectedIndex;
            if (currentIndex == -1)
            {
                return;
            }

            _currentStudent = _students[currentIndex];

            FullNameTextBox.Text = _currentStudent.FullName;
            IdTextBox.Text = Convert.ToString(_currentStudent.Id);
            GroupTextBox.Text = _currentStudent.Group;
            FacultyComboBox.Text = _currentStudent.Faculty;
            EducationFormComboBox.Text = _currentStudent.EducationForm;

        }

        /// <summary>
        /// Проверяет значения текстового поля (полное имя студента), при его изменении.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 201;
            if((Regex.IsMatch(FullNameTextBox.Text, @"^[А-Я]?[а-я]+\s?[А-Я]?[а-я]+\s?[А-Я]?[а-я]+$") || 
                Regex.IsMatch(FullNameTextBox.Text, @"^[А-Я]?[а-я]+\s?[А-Я]?[а-я]+$"))
                && FullNameTextBox.Text.Length < maxLength)
            {
                FullNameTipLabel.Text = "";
                ApplyAddButton.Enabled = true;
                ApplyChangesButton.Enabled = true;
                FullNameTextBox.BackColor = AppColors.White;
            }
            else if (FullNameTextBox.Text.Length >= maxLength)
            {
                FullNameTextBox.BackColor = AppColors.LightPink;
                FullNameTipLabel.Text = "Длина строки не должна превышать 200 символов.";
                ApplyAddButton.Enabled = false;
                ApplyChangesButton.Enabled = false;
            }
            else if (!Regex.IsMatch(FullNameTextBox.Text, @"^[А-Я]?[а-я]+\s?[А-Я]?[а-я]+\s?[А-Я]?[а-я]+$") ||
                     !Regex.IsMatch(FullNameTextBox.Text, @"^[А-Я]?[а-я]+\s?[А-Я]?[а-я]+$"))
            {
                FullNameTextBox.BackColor = AppColors.LightPink;
                FullNameTipLabel.Text = "В поле полное имя должны быть данные формата: Фамилия Имя Отчество / Фамилия Имя.";
                ApplyAddButton.Enabled = false;
                ApplyChangesButton.Enabled = false;
            }
        }

        /// <summary>
        /// Проверяет значения текстового поля (группа студента), при его изменении.
        /// </summary>
        private void GroupTextBox_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 11;
            if (GroupTextBox.Text.Length < maxLength)
            {
                GroupTextBox.BackColor = AppColors.White;
                GroupTipLabel.Text = "";
                ApplyAddButton.Enabled = true;
            }
            else
            {
                GroupTextBox.BackColor = AppColors.LightPink;
                GroupTipLabel.Text = "В поле группа строка не должна превышать 10 символов.";
                ApplyAddButton.Enabled = false;
            }
        }
        
        /// <summary>
        /// Метод для очистки информации.
        /// </summary>
        private void ClearInfo()
        {
            FullNameTextBox.Clear();
            GroupTextBox.Clear();
            FacultyComboBox.SelectedIndex = -1;
            EducationFormComboBox.SelectedIndex = -1;
            FullNameTipLabel.Text = "";
            GroupTipLabel.Text = "";
        }
        
        /// <summary>
        /// Метод для окрашивания в белый цвет всех, за исключением IdTextBox, полей.
        /// </summary>
        private void TextAndComboBoxesBackColorWhite()
        {
            FullNameTextBox.BackColor = AppColors.White;
            GroupTextBox.BackColor = AppColors.White;
            FacultyComboBox.BackColor = AppColors.White;
            EducationFormComboBox.BackColor = AppColors.White;
        }
        
        /// <summary>
        /// Метод для установления Enabled = false для всех TextBox и ComboBox.
        /// </summary>
        private void TextAndComboBoxesSwitch(bool flag)
        {
            FullNameTextBox.Enabled = flag;
            GroupTextBox.Enabled = flag;
            FacultyComboBox.Enabled = flag;
            EducationFormComboBox.Enabled = flag;
            IdTextBox.Enabled = flag;   
        }
        
        /// <summary>
        /// Метод для сортировки списка студентов с последующем заполнением ListBox.
        /// </summary>
        private void SortAndAddToListBox()
        {
            _students = _students.OrderBy(_currentStudent => _currentStudent.FullName)
                    .ToList();
            StudentsListBox.Items.Clear();
            StudentsListBox.Items.AddRange(_students.ToArray());
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
