using System;

namespace Addition_task
{
    class User
    {
        string login, name, surname;
        int age;
        readonly string date;
        public User(string login, string name, string surname, int age, string date)
        {
            this.date = date;
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void InformationOfPeople()
        {
            Console.WriteLine("Логин: {0}\nИмя: {1}\nФамилия: {2}\nВозраст: {3}\nДата заполнения анкеты: {4}", login, name, surname, age, date);
        }

    }
}
