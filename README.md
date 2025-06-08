# KafkaFinalWorkingProject

## Как да стартирате проекта

1. Отворете решението с Visual Studio.
2. Натиснете зеления бутон *HTTP (Swagger)* или *Start Without Debugging*.
3. Swagger ще се отвори автоматично. Там можете да тествате:

### 🎬 Movies
- GET /movies — връща всички филми
- POST /movies — добавя нов филм

### 📨 Kafka
- POST /kafka/publish — публикува филм в Kafka (в паметта)
- POST /kafka/consume — чете съобщения от Kafka (в паметта)
- GET /kafka/cache — връща всички кеширани филми

### 🌍 Външен API
- GET /api/external-movies — фалшив външен филмов API

## Забележка

Проектът използва *фалшиви версии на Kafka и MongoDB* (в паметта), така че не е нужно да инсталирате Kafka, MongoDB или Docker.