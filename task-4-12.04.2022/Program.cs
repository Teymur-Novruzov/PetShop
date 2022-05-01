using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_4_12._04._2022
{
    class PetShop
    {
        
        public Cat[] cats = new Cat[15];
        public int cat_count=0;
        public Dog[] dogs = new Dog[15];
        public int dog_count=0;
        public Bird[] birds = new Bird[15];
        public int bird_count=0;

        public void RemoveByNickNamePed(object[] class_name,int remove_id,int number)
        {
            for (int i = remove_id; i < class_name.Length-1; i++)
            {
                class_name[i] = class_name[i + 1];
            }
            if (number == 1)
            {
                --cat_count;
            }
            else if (number == 2)
            {
                --dog_count;
            }
            else if (number == 3)
            {
                --bird_count;
            }
            Show();
            Second_step();
        }
        public void Sell_Ped()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" your ped Cat , Dog or Bird ");
            Console.WriteLine();
            Console.Write(" Your Answer : ");
            string Employees_answer = Console.ReadLine();
            if(Employees_answer=="cat"|| Employees_answer == "Cat" || Employees_answer == " cat" || Employees_answer == " cat " 
               || Employees_answer == "cat " || Employees_answer == " Cat" || Employees_answer == "Cat " || Employees_answer == " Cat ")
            {
                if (cat_count == 15)
                {
                    Console.WriteLine(" Sorry Shop is full");
                }
                else
                {
                Add_Animal(add_catAndDog(), 1);
                }
            }
            else if (Employees_answer == "dog" || Employees_answer == "Dog" || Employees_answer == " dog" || Employees_answer == " dog "
               || Employees_answer == "dog " || Employees_answer == " Dog" || Employees_answer == "Dog " || Employees_answer == " Dog ")
            {
                if (dog_count == 15)
                {
                    Console.WriteLine(" Sorry Shop is full");
                }
                else
                {
                Add_Animal(add_catAndDog(), 2);
                }
            }
            else if (Employees_answer == "bird" || Employees_answer == "Bird" || Employees_answer == " bird" || Employees_answer == " bird "
               || Employees_answer == "bird " || Employees_answer == " Bird" || Employees_answer == "Bird " || Employees_answer == " Bird ")
            {
                if (bird_count == 15)
                {
                    Console.WriteLine(" Sorry Shop is full");
                }
                else
                {
                Add_Animal(add_Bird(), 3);
                }
            }
            else
            {
                Console.WriteLine(" Sorry, we don't need this Animal ");
            }
            
        }
        public void Add_animal_system(string nickname,string gender,string color,string charackter,
                                      double age,int price,int meal,string informatin_animal,int code)
        {
            if (code == 1)
            {
                Cat new_cat = new Cat(nickname, gender, color, charackter,
                       age, price, meal, informatin_animal);

                cats[cat_count++] = new_cat;

            }
            else if (code == 2)
            {
                Dog new_dog = new Dog(nickname, gender, color, charackter,
                       age, price, meal, informatin_animal);

                dogs[dog_count++] = new_dog;

            }
            else if (code == 3)
            {
                Bird new_bird = new Bird(nickname, gender, color, charackter,
                       age, price, meal, informatin_animal);

                birds[bird_count++] = new_bird;

            }
        }
        public void Add_Animal(string Animals_information,int id)
        {
            //
            //Console.Clear();
            Console.WriteLine();
            Console.Write(" Enter Animal's Nickname : ");
            string new_nickname = Console.ReadLine();

            Console.WriteLine();
            Console.Write(" Enter Animal's Gender : ");
            string new_Gender = Console.ReadLine();

            Console.WriteLine();
            Console.Write(" Enter Animal's Color : ");
            string new_Color = Console.ReadLine();
            
            Console.WriteLine();
            Console.Write(" Enter Animal's Charackter : ");
            string new_Character = Console.ReadLine();
            
            Console.WriteLine();
            Console.Write(" Enter Animal's Age : ");
            string new_Age_str = Console.ReadLine();
            double new_age;
            bool check_number=double.TryParse(new_Age_str, out new_age);
            if (check_number == false)
            {
                new_age = 0;
            }

            Console.WriteLine();
            Console.Write(" Enter Animal's Price : ");
            string new_Price_str = Console.ReadLine();
            int new_price;
            bool check_price = int.TryParse(new_Price_str, out new_price);
            if (check_price == false)
            {
                new_price = 0;
            }

            Console.WriteLine();
            Console.Write(" Enter Animal's Meal quantity : ");
            string new_Meal_str = Console.ReadLine();
            int new_Meal;
            bool check_meal = int.TryParse(new_Meal_str, out new_Meal);
            if (check_meal == false)
            {
                new_Meal = 0;
            }

            if (id == 1)
            {
                Cat new_cat=new Cat(new_nickname,new_Gender,new_Color,new_Character,
                       new_age,new_price,new_Meal,Animals_information);
                
                cats[cat_count++] = new_cat;
                
            } 
            else if (id == 2)
            {
                Dog new_dog=new Dog(new_nickname,new_Gender,new_Color,new_Character,
                       new_age,new_price,new_Meal,Animals_information);
                
                dogs[dog_count++] = new_dog;
               
            } 
            else if (id == 3)
            {
                Bird new_bird=new Bird(new_nickname,new_Gender,new_Color,new_Character,
                       new_age,new_price,new_Meal,Animals_information);
                
                birds[bird_count++] = new_bird;
                
            }
        }
        public string add_catAndDog()
        {
            Console.WriteLine();
            Console.Write(" Enter Animal's predator : ");
            string new_Predator = Console.ReadLine();
            return new_Predator;
        } 
        public string add_Bird()
        {
            Console.WriteLine();
            Console.Write(" Enter Animal's Wind Color : ");
            string new_Wind_color = Console.ReadLine();
            return new_Wind_color;
        }
        public void show_cat(int i)
        {
            Console.WriteLine();
            Console.WriteLine(" - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine($" NickName : {cats[i].Nickname}");
            Console.WriteLine();
            Console.WriteLine($" Gender : {cats[i].Gender}");
            Console.WriteLine();
            Console.WriteLine($" Color : {cats[i].Color}");
            Console.WriteLine();
            Console.WriteLine($" Character : {cats[i].Character}");
            Console.WriteLine();
            Console.WriteLine($" Age : {cats[i].Age}");
            Console.WriteLine();
            Console.WriteLine($" Energy : {cats[i].Energy}");
            Console.WriteLine();
            Console.WriteLine($" Price : {cats[i].Price}");
            Console.WriteLine();
            Console.WriteLine($" MealQuantity : {cats[i].MealQuantity}");
            Console.WriteLine();
            Console.WriteLine($" Predator : {cats[i].Predator}");
        }
        public void Show_cats()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Cats ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            for (int i = 0; i < cat_count; i++)
            {
                show_cat(i);
            }
        }
        public void show_dog(int i)
        {
            Console.WriteLine();
            Console.WriteLine(" - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine($" NickName : {dogs[i].Nickname}");
            Console.WriteLine();
            Console.WriteLine($" Gender : {dogs[i].Gender}");
            Console.WriteLine();
            Console.WriteLine($" Color : {dogs[i].Color}");
            Console.WriteLine();
            Console.WriteLine($" Character : {dogs[i].Character}");
            Console.WriteLine();
            Console.WriteLine($" Age : {dogs[i].Age}");
            Console.WriteLine();
            Console.WriteLine($" Energy : {dogs[i].Energy}");
            Console.WriteLine();
            Console.WriteLine($" Price : {dogs[i].Price}");
            Console.WriteLine();
            Console.WriteLine($" MealQuantity : {dogs[i].MealQuantity}");
            Console.WriteLine();
            Console.WriteLine($" Predator : {dogs[i].Predator}");
        }
        public void Show_dogs()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Dogs ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            for (int i = 0; i < dog_count; i++)
            {
                show_dog(i);
            }
        }
        public void show_Bird(int i)
        {
            Console.WriteLine();
            Console.WriteLine(" - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine($" NickName : {birds[i].Nickname}");
            Console.WriteLine();
            Console.WriteLine($" Gender : {birds[i].Gender}");
            Console.WriteLine();
            Console.WriteLine($" Color : {birds[i].Color}");
            Console.WriteLine();
            Console.WriteLine($" Character : {birds[i].Character}");
            Console.WriteLine();
            Console.WriteLine($" Age : {birds[i].Age}");
            Console.WriteLine();
            Console.WriteLine($" Energy : {birds[i].Energy}");
            Console.WriteLine();
            Console.WriteLine($" Price : {birds[i].Price}");
            Console.WriteLine();
            Console.WriteLine($" MealQuantity : {birds[i].MealQuantity}");
            Console.WriteLine();
            Console.WriteLine($" Wind_color : {birds[i].Wind_color}");
        }
        public void Show_birds()
        {
        Console.WriteLine();
        Console.WriteLine("++++++++++++++++++++++++++++++++++");
        Console.WriteLine(" Birds ");
        Console.WriteLine("++++++++++++++++++++++++++++++++++");
        Console.WriteLine();
        for (int i = 0; i < bird_count; i++)
        {
                show_Bird(i);
        }

    }

            public void Show()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Cats ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            for (int i = 0; i < cat_count; i++)
            {
                show_cat(i);
            }
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Dogs ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            for (int i = 0; i < dog_count; i++)
            {
                show_dog(i);
            }
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Birds ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            for (int i = 0; i < bird_count; i++)
            {
                show_Bird(i);
            }
        }
        public void Second_step()
        {
            Console.WriteLine();
            Console.WriteLine(" Which category do you want ? ");
            Console.WriteLine(" Cats [1]  -   Dogs [2]  -  Birds [3]  -  Sell animal [4]");
            Console.WriteLine();
            Console.Write(" Enter : ");
            string second_steps_choice = Console.ReadLine();
            if (second_steps_choice == "1")
            {
                Console.Clear();
                Show_cats();
            }
            else if(second_steps_choice == "2")
            {
                Console.Clear();
                Show_dogs();
            }
            else if(second_steps_choice == "3")
            {
                Console.Clear();
                Show_birds();
            }
            else if (second_steps_choice == "4")
            {
                Sell_Ped();
                Show();
                Second_step();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(" WRONG ");
                Console.WriteLine();
                Second_step();
            }
            if (second_steps_choice == "1" || second_steps_choice == "2" || second_steps_choice == "3")
            {

            Console.WriteLine();
            Console.WriteLine(" ******************************************  ");
            Console.WriteLine();
            Console.WriteLine(" Choice Animals Nickname");
            Console.WriteLine();
            Console.Write(" Enter : ");
            string second_steps_choice2 = Console.ReadLine();
           
            if (second_steps_choice == "1")
            {
                Console.Clear();
                for (int i = 0; i < cat_count; i++)
                {
                    if (cats[i].Nickname == second_steps_choice2)
                    {
                        show_cat(i);
                        Third_choice(1, i);
                    }
                }
            }
            else if (second_steps_choice == "2")
            {
                Console.Clear();
                for (int i = 0; i < dog_count; i++)
                {
                    if (dogs[i].Nickname == second_steps_choice2)
                    {
                        show_dog(i);
                        Third_choice(2, i);
                    }
                }
            }
            else if (second_steps_choice == "3")
            {
                Console.Clear();
                for (int i = 0; i < bird_count; i++)
                {
                    if (birds[i].Nickname == second_steps_choice2)
                    {
                        show_Bird(i);
                        Third_choice(3, i);
                    }
                }
            }
           
                Show();
                Second_step();
            
            }
        }
        public void Third_choice(int id,int index)
        {
            Console.WriteLine();
            Console.WriteLine("   Play [p]        Sleep [s]        Eat [e]        Buy [b]");
            Console.WriteLine();
            Console.Write(" Enter : ");
            string third_choices_str = Console.ReadLine();
            if (third_choices_str == "p"|| third_choices_str == "P")
            {
                if (id == 1)
                {
                cats[index].Play();
                    show_cat(index);
                    Third_choice(1,index);
                }
                else if (id == 2)
                {
                    dogs[index].Play();
                    show_dog(index);
                    Third_choice(2, index);
                }
                else if (id == 3)
                {
                    birds[index].Play();
                    show_Bird(index);
                    Third_choice(3, index);
                }
            }
            else if(third_choices_str == "s" || third_choices_str == "S")
            {
                if (id == 1)
                {
                    cats[index].Sleep();
                    show_dog(index);
                    Third_choice(1, index);
                }
                else if (id == 2)
                {
                    dogs[index].Sleep();
                    show_dog(index);
                    Third_choice(2, index);
                }
                else if (id == 3)
                {
                    birds[index].Sleep();
                    show_Bird(index);
                    Third_choice(3, index);
                }
            }
            else if(third_choices_str == "e" || third_choices_str == "E")
            {
                if (id == 1)
                {
                    cats[index].Eat();
                    show_Bird(index);
                    Third_choice(1, index);
                }
                else if (id == 2)
                {
                    dogs[index].Eat();
                    show_dog(index);
                    Third_choice(2, index);
                }
                else if (id == 3)
                {
                    birds[index].Eat();
                    show_Bird(index);
                    Third_choice(3, index);
                }
            }
            else if (third_choices_str == "b" || third_choices_str == "B")
            {
                if (id == 1)
                {
                    RemoveByNickNamePed(cats, index,1);
                    Console.Clear();
                    Console.WriteLine("                  You Got    ");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("                  You Got   ");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("                  You Got   ");
                    Thread.Sleep(750);
                }
                else if (id == 2)
                {
                    RemoveByNickNamePed(dogs, index,2); Console.Clear();
                    Console.WriteLine("                  You Got    ");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("                  You Got   ");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("                  You Got   ");
                    Thread.Sleep(750);
                }
                else if (id == 3)
                {
                    RemoveByNickNamePed(birds, index,3); Console.Clear();
                    Console.WriteLine("                  You Got    ");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("                  You Got   ");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("                  You Got   ");
                    Thread.Sleep(750);
                }
                Show();
            }

        }
    }
    class Animal 
    {
        public string Nickname { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public string Character { get; set; }
        public double Age { get; set; }
        public int Energy { get; set; }
        public int Price { get; set; }
        public int MealQuantity { get; set; }
        public Animal()
        {
            this.Nickname = string.Empty;
            this.Gender = string.Empty;
            this.Color = string.Empty;
            this.Character = string.Empty;
            this.Age = 0;
            this.Energy = 100;
            this.Price = 0;
            this.MealQuantity = 0;
        }
        public Animal(string new_Nickname,string new_Gender,string new_Color,string new_Character,
                      double new_Age,int new_Price,int new_Mealquantity)
        {
            this.Nickname = new_Nickname;
            this.Gender = new_Gender;
            this.Color = new_Color;
            this.Character = new_Character;
            this.Age = new_Age;
            this.Energy = 100;
            this.Price = new_Price;
            this.MealQuantity = new_Mealquantity;
        }
        public void Eat()
        {
            Console.Clear();
            if (this.Energy != 100&&this.Energy+20<=100)
            {
                this.Energy += 20;
                this.MealQuantity += 1;
                Console.WriteLine("                  Eating   ");
                Thread.Sleep(750);
                Console.Clear();
                Console.WriteLine("                  Eating   ");
                Thread.Sleep(750);
                Console.Clear();
                Console.WriteLine("                  Eating   ");
                Thread.Sleep(750);

            }
            else
            {
                Console.WriteLine(" The Animal not need food ");
            }
        }
        public void Sleep()
        {
            Console.Clear();
            if (this.Energy <= 20)
            {
                this.Energy += 80;
                this.Age += 0.05;
                this.Price += 1;
                Console.WriteLine("                  Sleeping   ");
                Thread.Sleep(750);
                Console.Clear();
                Console.WriteLine("                  Sleeping   ");
                Thread.Sleep(750);
                Console.Clear();
                Console.WriteLine("                  Sleeping   ");
                Thread.Sleep(750);
            }
            else
            {
                Console.WriteLine(" The Animal not need Sleep ");
            }
        }
        public void Play()
        {
            Console.Clear();
            if (this.Energy>=40)
            {
                this.Energy -= 40;
                Console.WriteLine("                  Playing   ");
                Thread.Sleep(750);
                Console.Clear();
                Console.WriteLine("                  Playing   ");
                Thread.Sleep(750);
                Console.Clear();
                Console.WriteLine("                  Playing   ");
                Thread.Sleep(750);
                if (this.Energy == 0)
                {
                    this.Sleep();
                }
            }
            else
            {
                Console.WriteLine(" The Animal not have Energy ");
            }

        }

    }
    class Cat:Animal
    {
        public string Predator { get; set; }
        public Cat():base()
        {
            this.Predator = string.Empty;
        }
        public Cat(string new_Nickname, string new_Gender, string new_Color, string new_Character,
                      double new_Age, int new_Price, int new_Mealquantity,string new_Predator):base
                   (new_Nickname,new_Gender,new_Color,new_Character,
                    new_Age,new_Price,new_Mealquantity)
        {
            this.Predator = new_Predator;
        }
    }
    class Dog:Animal
    {
        public string Predator { get; set; }
        public Dog() : base()
        {
            this.Predator = string.Empty;
        }
        public Dog(string new_Nickname, string new_Gender, string new_Color, string new_Character,
                      double new_Age, int new_Price, int new_Mealquantity, string new_Predator) : base
                   (new_Nickname, new_Gender, new_Color, new_Character,
                    new_Age, new_Price, new_Mealquantity)
        {
            this.Predator = new_Predator;
        }
    }
    class Bird:Animal
    {
        public string Wind_color { get; set; }
        public Bird() : base()
        {
            this.Wind_color = string.Empty;
        }
        public Bird(string new_Nickname, string new_Gender, string new_Color, string new_Character,
                      double new_Age, int new_Price, int new_Mealquantity, string new_Wind_Color) : base
                   (new_Nickname, new_Gender, new_Color, new_Character,
                    new_Age, new_Price, new_Mealquantity)
        {
            this.Wind_color = new_Wind_Color;
        }
    }
    class Start
    {
        PetShop Shop = new PetShop();
        public void Base_Start()
        {
            Shop.Add_animal_system("Mestan", "Erkek", "Qara", "Agresiv", 1, 100, 700, "Beli",1);
            Shop.Add_animal_system("IriGoz", "Disi", "Boz", "Sakit", 2, 70, 1700, "Xeyr",1);
            Shop.Add_animal_system("Gozel", "Disi", "Sari", "Sakit", 3, 60, 2700, "Xeyr", 1);
            Shop.Add_animal_system("Sirin", "Disi", "Ag", "Sakit", 4, 110, 3700, "Xeyr", 1);
            Shop.Add_animal_system("Akula", "Erkek", "Qara", "Agresiv", 5, 140, 4700, "Beli",1);

            Shop.Add_animal_system("Thor", "Erkek", "Ala bula", "Agresiv", 4, 100, 4700, "Xeyr",2);
            Shop.Add_animal_system("QARA", "Erkek", "Qara", "Agresiv", 1, 1000, 700, "Xeyr",2);
            Shop.Add_animal_system("Torpag", "Disi", "Boz", "Agresiv", 0.5, 500, 500, "Beli",2);
            Shop.Add_animal_system("Ayi", "Erkek", "AG", "Sakit", 1.5, 100, 1500, "Xeyr",2);
            Shop.Add_animal_system("Demir", "Erkek", "Qara", "Agresiv", 2, 200, 1700, "Beli",2);

            Shop.Add_animal_system("Ququ", "Erkek", "Ag", "Agresiv", 1, 100, 240, "Ag", 3);
            Shop.Add_animal_system("Bulbul", "Disi", "Qara", "Sakit", 1, 500, 300, "Ag", 3);
            Shop.Add_animal_system("Nazli", "Disi", "Qirmizi", "Sakit", 1, 400, 300, "Ag", 3);
            Shop.Add_animal_system("Kol", "Erkek", "Qara", "Sakit", 1, 200, 500, "Qirmizi", 3);
            Shop.Add_animal_system("Xalli", "Erkek", "Ala bula", "Sakit", 1, 1000, 700, "Qirmizi", 3);

        }
        public void Window_inf()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = " PetShop " ;
        }
        public void Start_method()
        {
            Window_inf();
            Shop.Show();
            Shop.Second_step();

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start();
            start.Base_Start();
            start.Start_method();
            
        }
    }
}
