using System;
namespace CalculatorLibrary.SimpleCalculator
{
	public interface ISimpleCalculator
	{
		int Add(int start, int amount);
        int Subtract(int start, int amount);
    }

	public class SimpleCalculator : ISimpleCalculator
	{
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}