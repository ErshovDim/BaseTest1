using SQLite;

namespace BaseTest
{ 
    public class Stadium
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; } // Название поля, если оно есть
        public string Location { get; set; } //Адрес
       // public int XLocation { get; set; } Необходим автоконверт адреса в координаты, по которым в теории будет легче искать поля в одной зоне
       // public int YLocation { get; set; } Проверить как это работает в тех же гугл/яндекс картах.
        public int Size { get; set; } // Количество участников
        // public ?? Photo { get; set; }  Фото как добавить и где хранить решить позже
        // public int Type { get; set; } //О чем говорили. 1 из 3 видов поля (платное, условно бесплатное, обычное дворовое). Сделать выпадающей менюшкой
        public string Description { get; set; } //Описание. Правила. Стоимость. Остальная информация

    }
}