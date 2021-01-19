using System;
using System.Collections.Generic;

namespace MyApp
{   class Device
    {
        public string name;
        private string firmware;
        private string patient;
        List<string> firmwareArray = new List<string>();
        public void DeclarerFirmware(string c)
        {
            if (firmware == null)
            {
                firmware = c;
                firmwareArray.Add(firmware);
                //Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("ko firmware déja déclaré");
            }
        }
        public void DeclarerPatient(string c)
        {
            if (patient == null)
            {
                patient = c;
                //Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("ko : patient déja associé");
           }
        }
        public void DissociationPatient(string c)
        {
            if (patient == c)
            {
                patient = null;
                //Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("ko ils n'étaient pas associés");
           }
        }
        public void MiseajourFirmware(string c)
        {
            firmware = c;
            firmwareArray.Add(firmware);
            Console.WriteLine("la liste des firmware du device : "+ string.Join("\t", firmwareArray));
        }
        public override string ToString()
        {  
            return base.ToString() + "{ name : " + name + ", firmware : " + firmware + ", patient : " + patient + " }";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Device slb1 = new Device();
            Device slb2 = new Device();
            Device slb3 = new Device();

            slb1.name = "SLB-01";
            slb1.DeclarerFirmware("FW-01");
            slb1.DeclarerPatient("User-01");

            slb2.name = "SLB-02";

            slb3.name = "SLB-03";

            //redéclaration du FW1 pour patient 1 :  ko firmware déja déclaré
            Console.WriteLine("redéclaration du FW1 pour patient 1 :");
            slb1.DeclarerFirmware("FW1-01");

            // déclaration du FW1 pour patient 2 :
            slb2.DeclarerFirmware("FW-01");
            Console.WriteLine("déclaraion du device 2 avec le firmware 1 : "+ slb2.ToString());

            // association du device 1  avec le patient 1 :  ko patient deja associé
            Console.WriteLine("association du device 1  avec patient 2 :");
            slb1.DeclarerPatient("User-02");

            //associationdu device 2 avec un patient 2 :
            slb2.DeclarerPatient("User-02");
            Console.WriteLine("association du device 2 avec le patient 2 : "+ slb2.ToString());

            // dissociation du patient 3 avec le device 1 : ko ils n'étaient pas associés
            Console.WriteLine("dissociation du patient 3 avec le device 3 :");
            slb3.DissociationPatient("User-03");

            //dissosiation du patient 1 avec patient 1 :
            slb1.DissociationPatient("User-01");
            Console.WriteLine("dissociation du patient 1 avec patient 1 : "+ slb1.ToString());



            //mise aà jour du device 1 avec firmware 2 :
            slb1.MiseajourFirmware("FW-02");
            Console.WriteLine("mise à jour du firmware : "+ slb1.ToString());



        }
    }
}