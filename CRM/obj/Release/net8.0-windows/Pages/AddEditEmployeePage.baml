   M S B A M L   `   `   `  ����   CRM#    CRM.Pages.AddEditEmployeePage   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  AddEditEmployeePage�� � 	Resources    MenuBorderButtonStyle �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   ShadowDepth   Color   Opacity	 �� Triggers
 P� Property P� Value��%�  &	        '��     '�� �    �� " ��.���  � �� �#39393B��  �@��CornerRadius$ 10����  �@��Padding$ 15q���  � ��$ 5q���  �@�Cursor$
 Hand����  � ��$ Stretch=���  � ��$ Center=���  � ��
 �������  � ��$ 14(���  � ��$ Center=���  � ��$ Center=���  �@J�Effect   $ 5Q�$ 2Q�$ Black��$	 0.5Q�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �#4E4E50��  �@J�Effect   $ 10Q�$ 3Q�$ Black��$	 0.7Q��� " ��.���  � �� �#2D2D2F��  � ��
 �������  � �� �#39393B��  � ��$ 1q���  � ��$ 5q���  � ��$ 0,5,0,10q��� " ��.���  � �� �#39393B��  � ��
 �������  � �� �#39393B��  � ��$ 1q���  � ��$
 10,5q���  � ��$ 5q���  �@�Cursor$
 Hand����  � ��$ Center=���  � ��$ Center=���  �@J�Effect   $ 5Q�$ 2Q�$ Black��$	 0.5Q�.��� ���#1C1C1C � ColumnDefinitions �� $	��220 ��� $��1* �.+��� $��0�����#2D2D2F$��10q�.+��� -   #��[  ._��� $��
Назад��� $��1�����#2D2D2F$��10q�.+��� $
��Auto=�.���� $��10q�.+��� $/��)Добавление сотрудника��
�������$��18(�$��Center=�$��0,0,0,20q��� $-��'Фамилия Имя Отчество:��
��������� -    ��Name$ FullNameTextBox���� $ ��Дата рождения:��
��������� -   $ BirthDateTextBox���� $��	Опыт:��
��������� -   $ ExperienceTextBox���� $.��(Дата приема на работу:��
��������� -   $ DateOfEmploymentTextBox���� $��Отдел:��
��������� -    ��Name$ DepartmentTextBox���� $��Должность:��
��������� -   $ PositionTextBox���� $��Пол:��
��������� -   $ GenderTextBox��$��60�� �� TextWrapping$
 Wrap=��� $��Телефон:��
��������� -	   $ PhoneTextBox��$��60��$
 Wrap=��� $��Почта:��
��������� -
   $ EmailTextBox��$��60��$
 Wrap=��� $��Заметки:��
��������� -   $ NotesTextBox��$��60��$
 Wrap=��� $$��Прикрепить файл:��
��������� -    ��Name$ AttachFileButton��$(��"📎 Прикрепить файл��$��0,5,0,10q���  �� Orientation$ 
Horizontal=�$��Right=�$��0,20,0,0q�.+��� -   $��Сохранить��$��5q��� -   $��Отмена��$��5q�