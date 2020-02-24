using System;



namespace Character_imput

{

    class Program

    {

        

        //static int posX = 0;

        //static int posY = 0;

        static string lastPosPressed = "";



        //arriba

        static void PressUp() {

            if(lastPosPressed == ""){

               lastPosPressed = "up"; 

            }

            

        }

        static void ReleaseUp(){

            if (lastPosPressed == "up"){

             //mover hacia arriba

              posY--;   

              lastPosPressed = "";

            }

           

        }



        //abajo

        static void PressRight() {

            if(lastPosPressed == ""){

               lastPosPressed = "Right"; 

            }

            

        }



         static void ReleaseRight()

         {

            if (lastPosPressed == "Right")

            {

              posX++;   

              lastPosPressed = "";

            }

         }



        static void PressDown() {

            if(lastPosPressed == ""){

               lastPosPressed = "down"; 

            }

            

        }

        static void ReleaseDown(){

            if (lastPosPressed == "down"){

             //mover hacia arriba

              posY++;   

              lastPosPressed = "";

            }

           

        }

        static void Main(string[] args)

        {

           // PressUp();

           //ReleaseUp();



            //PressRight();

            //PressDown();

            //ReleaseRight();



            //PressRight();

            //ReleaseRight();



            for(int posX = 0; posX<=500; posX++)

            for(int posY = 0; posY >= -500; posY--){



            

                Console.WriteLine(posX + "," + posY);

            }

        }

    }

}
