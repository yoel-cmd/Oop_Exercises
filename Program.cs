using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi");


            //WrenchTool wrench = new WrenchTool("wrench", "3");

            DrillTool drill1 = new DrillTool("drill 1", "3.5");
            DrillTool drill2 = new DrillTool("drill 2", "4.4");
            HammerTool hammer1 = new HammerTool("hammer 1", "7.5");
            NailGunTool nailGun = new NailGunTool("nailGun 1", "0.3");
            WireStripperTool wire = new WireStripperTool("wire 1", "2.6");

            List<Tool> listTool = new List<Tool>();
            listTool.Add(drill1);
            listTool.Add(drill2);
            listTool.Add(hammer1);
            listTool.Add(nailGun);
            listTool.Add(wire);


            foreach (Tool item in listTool)
            {
                item.Describe();
                item.Use();
            }

            

        }
    }
}
