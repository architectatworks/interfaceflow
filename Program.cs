using System;

namespace InterfaceApp
{
    class Program
    {
        public enum fntocall
        {
            DistRest =0,
            RBDRest =1
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WrapperClass(fntocall.DistRest));
            Console.WriteLine(WrapperClass(fntocall.RBDRest));
            Console.WriteLine("Hello World!");
        }

        public static string WrapperClass(fntocall _fntocall)
        {
            IRSCaseInterface objIRSCaseInterface = new RSCaseClass();
            switch (_fntocall.ToString())
            {
                case "DistRest":
                  
                    return objIRSCaseInterface.CreateDisRest(null);

                case "RBDRest":
                    
                    return objIRSCaseInterface.CreateRBDRest(null);
            }
            return null;
        }
    }
}
