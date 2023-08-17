using Bunker.GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Creatures
{
    abstract class Player
    {
        Engine engine = null;
        public Player(string name)
        {
            this.name = name;
        }

        protected string name = ""; //гравець
        protected string job = ""; //робота
        protected string bioCharacteristics = ""; //біологічна характеристика
        protected string sex = ""; //стать
        protected int age = 0; //вік
        protected string orientation = ""; //орієнтація
        protected string hobby = ""; //хоббі
        protected string phobia = ""; //фобія
        protected string nature = ""; //характер
        protected string addInformation = ""; //дополнітельна характеристика
        protected string knowledg = ""; //знання
        protected string baggage = ""; //багаж
        public void setName(string name) => this.name = name;
        public string getName() => this.name;
        public void setJob(string job) => this.job = job;
        public string getJob() => this.job;
        public void setSex(string sex) => this.sex = sex;
        public string getSex() => this.sex;
        public void setAge(int age) => this.age = age;
        public int getAge() => this.age;
        public void setOrientation(string orientation) => this.orientation = orientation;
        public string getOrientation() => this.orientation;
        public void setHobby(string hobby) => this.hobby = hobby;
        public string getHobby() => this.hobby;
        public void setPhobia(string phobia) => this.phobia = phobia;
        public string getPhobia() => this.phobia;
        public void setNature(string nature) => this.nature = nature;
        public string getNature() => this.nature;
        public void setAI(string addInformation) => this.addInformation = addInformation;
        public string getAI() => this.addInformation;
        public void setKnowledg(string knowledg) => this.knowledg = knowledg;
        public string getKnowledg() => this.knowledg;
        public void setBaggage(string baggage) => this.baggage = baggage;
        public string getBaggage() => this.baggage;

        public void showInfo() 
        {
            Engine engine = new Engine();
            engine.Text("Стать: ", this.sex, color2: ConsoleColor.Yellow);
            engine.Text("Ім'я: ", this.name, color2: ConsoleColor.Blue);
            engine.Value("Вік: ", this.age, color2: ConsoleColor.DarkCyan);
            engine.Text("Орієнтація: ", this.orientation, color2: ConsoleColor.DarkCyan);
            engine.Text("Біологічна характеристика: ", this.bioCharacteristics, color2: ConsoleColor.Cyan);
            engine.Text("Характер: ", this.nature, color2: ConsoleColor.Red);
            engine.Text("Робота: ", this.job, color2: ConsoleColor.Green);
            engine.Text("Хобі: ", this.hobby, color2: ConsoleColor.DarkYellow);
            engine.Text("Фобія: ", this.phobia, color2: ConsoleColor.DarkRed);           
            engine.Text("AddInformation: ", this.addInformation, color2: ConsoleColor.DarkBlue);
            engine.Text("Знання: ", this.knowledg, color2: ConsoleColor.Magenta);
            engine.Text("Багаж: ", this.baggage, color2: ConsoleColor.DarkGreen);
        }
    }
}
