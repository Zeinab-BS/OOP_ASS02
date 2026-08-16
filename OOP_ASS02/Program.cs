namespace OOP_ASS02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1

            //a) What is the difference between a class and a struct?

            /*  class                                struct 
             
             - refernce type                         value type 
             
             - store in heap and                     store in stack
               refernce stroe in stack

            - can be null                            can not be null

            - support inheritance                    doesnot support inheritance

            - copies by refernce                     copies by value 

            - best for complex data with             best for simple data with 
              more logic and validation              less validation ,logic and functionality

            -   Defualt CTOR defined if              always exist 
                none defined if we define 
                paramterized CTOR CLR will
                delete Defualt CTOR

            - Allowed Access Modifiers in class     Allowed Access Modifiers in Struct
            
               *private                             *private
               *public                              *public  
               *protected                           *internal
               *internal
               *internal proteced
               *private protected 
          

             //b) Why are classes more suitable than structs for large applications?

            /*
             classes more suitable than structs for large applications becuase they are 
             refernce type so many parts in the program can share the same object without
             copying the values and also classes support important OOP features such as [inheritance,polymorphism]
             */


           







            #endregion

            #region Question2

            /*
             public class Shipment{

            public string TrackingCode{get; set;}


            }

            public class ExpressShipment:Shipment{

            public decimal ExtraFree{get; set;}

            }
           
             Which class is the parent class?

            - Shipment

            Which class is the child class?

            - ExpressShipment

            What members are inherited by ExpressShipment?
            - TrackingCode Property 


             Why is inheritance better than duplicating the same code in multiple classes?

            becuase inheritance allow us to reuse code of parent class in multiple classes 
            instead of duplicating the same code ,this make code easier to maintain and efficient 
            for the memory
            
           */

            #endregion

            #region Question3
            Console.Write(" Enter Delivery Center Name :");
            string name= Console.ReadLine();
            DeliveryCenter d = new DeliveryCenter(name);
            Console.WriteLine(" =====Standarad Shipment ===== ");
            Console.Write("Tracking Code :");
            string tc1= Console.ReadLine();

            Console.Write("Description: ");
            string des1 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal w1 = decimal.Parse(Console.ReadLine());

            Console.Write("DeliveryFee: ");
            decimal df1 = decimal.Parse(Console.ReadLine());


            Console.Write("City: ");
            string c1 = Console.ReadLine();


            Console.Write("Street: ");
            string st1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int BuildingNumber1 = int.Parse(Console.ReadLine());
            DeliveryAddress dAdress1 = new DeliveryAddress(c1, st1, BuildingNumber1);
            StandardShipment s =new StandardShipment(tc1,des1,w1,df1, dAdress1);
            Console.WriteLine();




            Console.WriteLine(" =====Express Shipment ===== ");
            Console.Write("Tracking Code :");
            string tc2 = Console.ReadLine();

            Console.Write("Description: ");
            string des2 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal w2 = decimal.Parse(Console.ReadLine());

            Console.Write("DeliveryFee: ");
            decimal df2 = decimal.Parse(Console.ReadLine());


            Console.Write("City: ");
            string c2 = Console.ReadLine();


            Console.Write("Street: ");
            string st2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int BuildingNumber2 = int.Parse(Console.ReadLine());
            DeliveryAddress dAdress2 = new DeliveryAddress(c2, st2, BuildingNumber2);
            Console.Write("ExtraFee: ");
            decimal extra=decimal.Parse(Console.ReadLine());
            ExpressShipment ex= new ExpressShipment(tc2, des2, w2, df2, dAdress2, extra);
            Console.WriteLine();



            Console.WriteLine(" =====international Shipment ===== ");
            Console.Write("Tracking Code :");
            string tc3 = Console.ReadLine();

            Console.Write("Description: ");
            string des3 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal w3 = decimal.Parse(Console.ReadLine());

            Console.Write("DeliveryFee: ");
            decimal df3 = decimal.Parse(Console.ReadLine());


            Console.Write("City: ");
            string c3 = Console.ReadLine();


            Console.Write("Street: ");
            string st3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int BuildingNumber3 = int.Parse(Console.ReadLine());
            DeliveryAddress dAdress3 = new DeliveryAddress(c3, st3, BuildingNumber3);
            Console.Write("DestinationCountry: ");
            string desct= Console.ReadLine();
            Console.Write("CustomeFee: ");
            decimal cfee = decimal.Parse(Console.ReadLine());
            InternationalShipment inetr = new InternationalShipment(tc3, des3, w3, df3, dAdress3, desct, cfee);
            Console.WriteLine();
           
            
            /**************Add shipments ***************/   
            bool addStandarad = d.AddShipment(s);
            if (addStandarad)
            {
                Console.WriteLine("Shipment added successfully.");
            }
            else
            {
                Console.WriteLine("Delivery Center is full.");
            }

 
            bool addExpress= d.AddShipment(ex);
            if (addExpress)
            {
                Console.WriteLine("Shipment added successfully.");
            }
            else
            {
                Console.WriteLine("Delivery Center is full.");
            }

           bool addInter= d.AddShipment(inetr);

            if (addExpress)
            {
                Console.WriteLine("Shipment added successfully.");
            }
            else
            {
                Console.WriteLine("Delivery Center is full.");
            }
            /**************Print shipments ***************/

            Console.WriteLine("======All Shipments======");
            d.PrintAllShipments();



            /************** Search For Shipment  *****************/

            Console.Write("Enter Tracking Code For Search: ");

            string TC= Console.ReadLine();

            Shipment foundCode = d[TC];

            if (foundCode != null)
            {
                Console.WriteLine($"Shipment Is Founded :{foundCode.Description}-{foundCode.TrackingCode}");
            }

            else
            {
                Console.WriteLine("Shipment Can Not Found ");
            }


            /************** Removing Shipment  *****************/


            Console.Write("Enter Tracking Code That You Want To Remove:");

            string trackingCode= Console.ReadLine();
            bool remove = d.RemoveShipment(trackingCode);
            if (remove)
            {
                Console.WriteLine("Your Shipment Is Removed Successfully!");

            }

            else
            {
                Console.WriteLine("Shipment Not Found !");
            }


            /************** Print Remaining Shipments  *****************/

            Console.WriteLine("=====Remaining Shipments====");
            d.PrintAllShipments();















            #endregion








        }








    }


    
}