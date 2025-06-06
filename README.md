# CRM для HR

Система управления взаимоотношениями с сотрудниками и соискателями (CRM) для отделов кадров, позволяющая централизованно хранить данные о сотрудниках и кандидатах, оптимизировать процесс найма.

![GitHub top language](https://img.shields.io/badge/Язык-C%23-синий)
![База данных](https://img.shields.io/badge/База_данных-PostgreSQL-336791)

## Обзор

Эта CRM-система предоставляет централизованную платформу для хранения и управления информацией о сотрудниках и кандидатах, управления процессами найма и планирования HR-мероприятий. Включает функции профилей сотрудников и кандидатов, HR-календаря, управления тестовыми заданиями.

## Установка

### Предварительные требования
- [.NET SDK](https://dotnet.microsoft.com/download) (последняя версия)
- [PostgreSQL](https://www.postgresql.org/download/) (последняя версия)
- Git

### Шаги
1. Клонируйте репозиторий
   ```bash
   git clone https://github.com/yourusername/CRM.git
   ```
2. Перейдите в директорию проекта
   ```bash
   cd CRM
   ```
3. Восстановите зависимости
   ```bash
   dotnet restore
   ```
4. Настройте базу данных PostgreSQL
   - Создайте новую базу данных.
   - Обновите строку подключения в `appsettings.json` с вашими учетными данными PostgreSQL.
5. Скомпилируйте и запустите приложение
   ```bash
   dotnet build
   dotnet run
   ```

## Документация
Пользовательская документация доступна в директории [docs](CRM/docs).

## Возможности
- Управление профилями сотрудников и кандидатов
- HR-календарь для планирования собеседований и мероприятий
- Управление тестовыми заданиями
- Поддержка прикрепления файлов (резюме, документы)

## Технический стек
- **Язык**: C#
- **База данных**: PostgreSQL

## Структура проекта
- `CRM/`: Основная директория проекта
  - `bin/`: Выходные файлы сборки
  - `obj/`: Объектные файлы
  - `App.xaml`, `App.xaml.cs`: Точки входа приложения
  - `MainWindow.xaml`, `MainWindow.xaml.cs`: Главное окно UI и код
  - `Classes/`: Логика бизнеса и модели
  - `Elements/`: Повторно используемые компоненты UI
  - `Pages/`: Страничные XAML и код
  - `CRM.csproj`: Конфигурация проекта

## Поддержка
При возникновении проблем или вопросов создайте [обсуждение](https://github.com/yourusername/CRM/issues/new/choose).
