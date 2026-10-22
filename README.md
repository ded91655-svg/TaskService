# Task Service API

Простое API на C# (.NET 8) со списком задач. Тема проекта: сервис задач.

## Endpoints
- GET /tasks — список задач (JSON)
- GET /health — проверка работоспособности ("OK")

## Сборка Docker-образа
docker build -t task-service .

## Запуск контейнера
docker run -d -p 8080:8080 --name my-task-api task-service

## Проверка работы
1. Проверить, что контейнер запущен: `docker ps`
2. Открыть в браузере http://localhost:8080/tasks
3. Посмотреть логи контейнера: `docker logs my-task-api`

## Остановка контейнера
docker stop my-task-api