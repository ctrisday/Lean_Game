A. Khai báo, khởi tạo và sử dụng class
   	A\1. Cú pháp:
        class <Tên lớp>
        {
            <Phạm vi truy cập> <Các thành phần của lớp>;
        }
    
        - Ví dụ:
            class Animal
            {
                public double Weight;
                public double Height;

                public void Run()
                {
                    Console.WriteLine(" Animal is running. . .");
                }
            }
            
    A\2. Khởi tạo:
        - Bạn có thể khởi tạo 1 đối tượng thuộc lớp thông qua toán tử new
        - Ví dụ: 
            Animal Dog = new Animal();

    A\3. Sử dụng:
        - Để sử dụng thuộc tính (tương tự biến) ta gọi trong hàm Main như sau:
            <tên đối tượng>.<tên thuộc tính>;
        - Để sử dụng phương thức (còn gọi là hàm) ta gọi trong hàm Main như sau:
            <tên đối tượng>.<tên phương thức>(<danh sách tham số nếu có>);
        - Ví dụ: 
            //Khởi tạo đối tượng cho class Animal
            Animal Cat = new Animal();

            //Gọi thuộc tính của đối tượng
            Cat.Weight = 1;
            Cat.Height = 30;

            // Gọi phương thức của đối tượng
            Dog.Info(); 
            Cat.Info();
        #Luu ý:
            - Thuộc tính dùng như biến, có thể gán giá trị
                Ví dụ: Cat.Weight = 12;
            - Phương thức dùng như hàm, gọi phương thức để xử lý việc gì đó
                Ví dụ: Cat.Info();

B. Phương thức khởi tạo, phương thức huỷ bỏ
    B\1. Phương thức khởi tạo
        B\1\1. Đặc điểm:
            - Có tên trùng với tên lớp
            - Nếu như bạn không khai báo bất kỳ phương thức khởi tạo nào thì hệ thống sẽ tự tạo ra phương thức khởi tạo mặc định không đối số và không có nội dung gì
            - Có 2 loại phương thức khởi tạo:
                +  Phương thức khởi tạo không đối số:
                    Là phương thức khởi tạo không có bất kỳ tham số truyền vào nào.
                    Thường dùng để khởi tạo các giá trị mặc định cho các thuộc tính bên trong class khi khởi tạo đối tượng (giá trị mặc định này do người lập trình quyết định).
                + Phương thức khởi tạo có đối số:
                    Là phương thức khởi tạo có tham số truyền vào. Và khi khởi tạo đối tượng để phương thức này được gọi ta cần truyền đầy đủ các tham số.
                    Thường dùng để khởi tạo các giá trị cho các thuộc thuộc tính bên trong class khi khởi tạo đối tượng (các giá trị này do người khởi tạo đối tượng truyền vào).
            - Ví dụ:
                class Cat
                {
                    public double Weight;
                    public double Height;
                    
                    //Phương thức khởi tạo không đối số
                    public Cat()
                    {
                        Weight = 800;
                        Height = 10;
                    }

                    //Phương thức khởi tạo có đối số
                    public Cat(int w, int h)
                    {
                        Weight = w;
                        Height = h;
                    }

                    public void Info()
                    {
                        Console.WriteLine(" Height: " + Height + " Weight: " + Weight);
                    }
                }