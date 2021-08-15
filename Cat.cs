using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritace
{
    class Cat : Animal//ทำการสืบทอดคลาสมาจากคลาส Animal (หรือเรียกว่า Inherit) ClassCat คือ supClass
    {
        public void Gose()//Method ที่เพิ่มมาเอง Class แม่จะไม่สามารถเรียกใช้งานได้
        {
            Console.WriteLine("meow meow");
        }
    }
}
