using System;

public class Cubo
{
	public Cubo()
	{
		double arista;
		int color;
		int trazo;

		public Cubo()
        {

        }

		public double GetArea()
        {
			return 6 * Math.Pow(arista, 2);
        }


		public double GetVolumen()
		{ 
		    return Math.Pow(arista, 3);
		}




	}
}
