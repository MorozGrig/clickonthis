# BusStationApp (WinForms, .NET Framework)

Рабочая основа desktop-приложения «Автовокзал» с многослойной архитектурой:

- `BusStationApp.UI` — WinForms формы и UI-логика.
- `BusStationApp.BLL` — бизнес-логика (авторизация, корзина, каталог).
- `BusStationApp.DAL` — Entity Framework 6 контекст, сущности, репозитории.
- `BusStationApp.Common` — общие DTO, интерфейсы, enum и валидация.
- `DatabaseScripts/CreateBusStationDb.sql` — SQL-скрипт создания БД.

## Быстрый старт

1. Открыть `BusStationApp/BusStationApp.sln` в Visual Studio 2022.
2. Восстановить NuGet-пакеты.
3. Проверить строку подключения `BusStationDb` в `BusStationApp.UI/App.config`.
4. Запустить проект `BusStationApp.UI`.

## Основные формы

- LoginForm
- RegisterForm
- MainForm
- CatalogForm
- CartForm
- AdminPanelForm
