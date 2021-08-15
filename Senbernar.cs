using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritace
{
    class Senbernar : Dog//ทำการสืบทอดคลาสมาจากคลาส Dog (หรือเรียกว่า Inherit) ClassSenberner คือ supClass
    {
        public void Goes()//Method ที่เพิ่มมาเอง Class แม่จะไม่สามารถเรียกใช้งานได้
        {
            Console.WriteLine("Wooooooooooof!!!");
        }
    }
}
