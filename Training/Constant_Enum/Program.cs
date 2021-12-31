using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_Enum
{
    //1. Struct , enum là value type.
    //2. Phân biệt enum khác gì với struct , class:
    //Kiểu liệt kê (enum) khai báo một tập hợp các hằng số có tên,
    //mặc định giá trị các hằng số này là kiểu int và bắt đầu từ 0 trở đi trong khai báo kiểu liệt kê.
    //Liệt kê (enum) thuộc dạng kiểu giá trị như struct.
    //Để khai báo một kiểu liệt kê thì dùng từ khóa enum
    //struct kiểu dữ liệu cấu trúc (còn gọi là structure)
    //- kiểu dữ liệu này tạo thành khi ta muốn gộp các dữ liệu có liên quan thành một nhóm (đóng gói dữ liệu).
    //Để tạo ra kiểu dữ liệu cấu trúc dùng đến từ khóa struct với khai báo khá giống khai báo lớp
    class Program
    {
        public struct People
        {
            public string people_id;
            public string name;
            public int age;
            public string address;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            People people;
            people.people_id = "10001";
            people.name = "Đinh Minh Đức";
            people.age = 21;
            people.address = "Hà Nội";
            Console.WriteLine("people_id: " + people.people_id);
            Console.WriteLine("name: " + people.name);
            Console.WriteLine("age: " + people.age);
            Console.WriteLine("address: " + people.address);
            Console.ReadLine();
        }
    }
}
