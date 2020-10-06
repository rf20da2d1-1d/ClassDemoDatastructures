using System;
using System.Collections.Generic;

namespace ClassDemoDatastructures
{

    public class InsertCodeHere
    {
        public void Start(){

            // erklære
            int[] array;

            // opretter
            array = new int[22];

            int tal = array[3]; // plads 4 da vi starter fra 0

            array[3] = 6;

            //fylder array op 

            for(int i = 0; i < 22; i++){
                array[i] = 1;
            }
            
            array[3] = 6;
            int sum = 0;
            for(int i = 0; i < 22; i++){
                sum = sum + array[i];
            }
            System.Console.WriteLine("Summen er " + sum);

            // finder et tal udenfor index
            //int taludenfor = array[22];

            // array af studerende
            
            // erklære
            Studerende[] studerende;

            // opretter
            studerende = new Studerende[22];

            studerende[0] = new Studerende();
            studerende[0].Nr = 45;
            studerende[0].Navn = "Kurt";

            studerende[1] = new Studerende();
            studerende[1].Nr = 46;
            studerende[1].Navn = "Elisabeth";

            // LIste 

            // erklære
            List<Studerende> liste;

            // oprette liste
            liste = new List<Studerende>();

            Studerende s = new Studerende();
            s.Nr = 33;
            s.Navn = "Jakob";

            liste.Add(s);
            liste.Add(s);

            System.Console.WriteLine("Nr=" + liste[0].Nr + " navn er " + liste[1].Navn);

            Studerende fundetS = liste.Find( s => s.Nr == 33);
            System.Console.WriteLine("FundetS Nummer er " + fundetS.Nr);

// returnerer ingen objekt
            Studerende ikkefundetS = liste.Find( s => s.Nr == 32);
            //System.Console.WriteLine("Ikke FundetS Nummer er " + ikkefundetS.Nr);






            




        }



    }


}