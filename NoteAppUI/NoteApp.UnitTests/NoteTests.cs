﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTests
    {
        [Test(Description = "Тест геттера Name")]
        public void Test_Name_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = new Note();
            var expected = "Name1";
            note.Name = expected;

            // Act
            var actual = note.Name;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }

        [Test(Description = "Нигативный тест сеттера Name")]
        public void Test_Name_WrongName_ThrowsException()
        {
            // Setup
            var note = new Note();
            string wrongName = "ErrorErrorErrorErrorErrorErrorErrorErrorError" +
                "ErrorErrorErrorErrorErrorErrorErrorError";

            // Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                // Act
                note.Name = wrongName; 
            },"Должно возникать исключение, если фамилия длиннее 50 символов");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void Test_Name_CorrectValue_SetsCorrectValue()
        {
            //Setup
            var note = new Note();
            string excepted = "Name1";

            //Act
            note.Name = excepted;
            string actual = note.Name;

            // Assert
            Assert.AreEqual(excepted, actual, "Сеттер устанавливает неверное значение");
        }

        [Test(Description = "Присвоение пустой строки для Name")]
        public void Test_Name_EmptyValue_SetsDefaultValue()
        {
            // Setup
            var note = new Note();
            var expected = "Без названия";

            // Act
            note.Name = "";
            var actual = note.Name;

            // Assert
            Assert.AreEqual(expected, actual,"Сеттер устанавливает неверное значение");
        }



        [Test(Description = "Тест геттера Category")]
        public void Test_Category_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = new Note();
            NoteCategory expected = NoteCategory.Other;
            note.NoteCategory = expected;

            // Act
            var actual = note.NoteCategory;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Category возвращает неправильную категорию");
        }

        [Test(Description = "Позитивный тест сеттера Category")]
        public void Test_Category_CorrectValue_SetsCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = NoteCategory.Other;

            //Act
            note.NoteCategory = expected;
            var actual = note.NoteCategory;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер устанавливает неверное значение");
        }

        [Test(Description = "Позитивный тест геттера Text")]
        public void Test_Text_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = new Note();
            var expected = "TextTextText";
            note.NoteText = expected;
            // Act
            var actual = note.NoteText;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Text возвращает неправильную категорию");
        }

        [Test(Description = "Позитивный тест сеттера Text")]
        public void Test_Text_CorrectValue_SetsCorrectValue()
        {
            //Setup
            var note = new Note();
            var expected = "Text1";

            //Act
            note.NoteText = expected;
            var actual = note.NoteText;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер устанавливает неверное значение");
        }

        [Test(Description = "Позитивный тест геттера CreatedTime")]
        public void Test_CreatedTime_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = new Note();
            var expected = DateTime.Now;
            note.CreationTime = expected;

            // Act
            var actual = note.CreationTime;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер DateOfCreation возвращает неправильное время");
        }

        [Test(Description = "Позитивный тест сеттера CreatedTime")]
        public void Test_CreatedTime_CorrectValue_SetsCorrectValue()
        {
            // Setup
            var note = new Note();
            var expected = DateTime.Now;

            // Act
            note.CreationTime = expected;
            var actual = note.CreationTime;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер устанавливает неверное значение");
        }

        [Test(Description = "Позитивный тест геттера ModifiedTime")]
        public void Test_ModifiedTime_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = new Note();

            var expected = DateTime.Now;

            // Act
            note.ModifiedTime = expected;

            // Assert
            var actual = note.ModifiedTime;
            Assert.AreEqual(expected, actual, "Геттер ModifiedTime возвращает неправильное время");
        }

        [Test(Description = "Позитивный тест сеттера ModifiedTime")]
        public void Test_ModifiedTime_CorrectValue_SetsCorrectValue()
        {
            //Setup
            var note = new Note();

            var expected = DateTime.Now;

            //Act
            note.ModifiedTime = expected;
            var actual = note.ModifiedTime;

            // Assert
            Assert.AreEqual(expected, actual, "Сеттер устанавливает неверное значение");
        }

        [Test(Description = "Тест конструктора")]
        [TestCase("Name1", "Text1", NoteCategory.Work)]
        public void Test_Constructore_SetsCorrectValue(string expectedName, string expectedText, 
            NoteCategory expectedCategory)
        {
            // Setup
            var note = new Note();

            // Act
            note = new Note(expectedName,expectedText,expectedCategory);

            // Setup
            Assert.AreEqual(expectedName, note.Name);
            Assert.AreEqual(expectedText, note.NoteText);
            Assert.AreEqual(expectedCategory, note.NoteCategory);
        }
    }
}
