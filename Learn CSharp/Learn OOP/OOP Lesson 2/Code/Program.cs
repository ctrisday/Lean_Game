using System;

namespace OOP
{
    class Animal
    {
        public string Name; //Khởi tạo thuộc tính
        public byte Age; //Khởi tạo thuộc tính
        public string Color; //Khởi tạo thuộc tính
        public Animal() //Phương thức khởi tạo không đối số. Ở đây là mặc định
        {
            Name = "";
            Age = 0;
            Color = "";
        }
        public Animal(string N, byte A, string C) //Phương thức khởi tạo có đối số. Người khởi tạo truyền vào
        {
            Name = N;
            Age = A;
            Color = C;
        }
        public void Render() //Khởi tạo phương thức xử lý (hàm) thực hiện lệnh bên trong cặp {}
        {
            Console.WriteLine("Ten: {0} \nTuoi: {1} \nMau: {2} \n", Name, Age, Color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal Cat = new Animal(); // Khởi tạo đối tượng cho class Animal

            Cat.Render(); //Gọi phương thức xử lý

            Cat.Name = "Cica"; //Gọi thuộc tính và gán giá trị cho thuộc tính của đối tượng Cat
            Cat.Age = 2; //Gọi thuộc tính và gán giá trị cho thuộc tính của đối tượng Cat
            Cat.Color = "White"; //Gọi thuộc tính và gán giá trị cho thuộc tính của đối tượng Cat

            Cat.Render();

            Animal Dog = new Animal("Cun", 3, "Black"); //Khởi tạo phương thức có đối số

            Dog.Render();

        }
    }
}