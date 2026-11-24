using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController: ControllerBase
    {
        Massiv.Math clsMathServise =new Massiv.Math();



        [HttpGet("SumNubers")]
           
        public int Get(double num1, int num2) => (int) clsMathServise.sum(num1, num2);

        [HttpGet("SubNubers")]
        public int Sub(double num1, int num2) => (int) clsMathServise.Sub(num1, num2);

        [HttpGet("MulNubers")]
        public int Mul(double num1, int num2) => clsMathServise.Mul(num1, num2);

        [HttpGet("DivNubers")]
        public int Div(double num1, int num2) => clsMathServise.Div(num1, num2);

        [HttpGet("IntDivNubers")]

        public int IntDiv(double num1, int num2) => clsMathServise.IntDiv(num1, num2);

        [HttpGet("PercenNubers")]

        public double Percent(double total, float percent) => clsMathServise.Percent(total, percent);

        [HttpGet("DePercentNubers")]

        public int DePercent(double num1, int num2) => clsMathServise.DePercent(num1, num2);

        [HttpGet("CountNubers")]

        public int Count(double num1, int num2) => clsMathServise.Count(num1, num2);

        [HttpGet("MaxNubers")]

        public int Max(double num1, int num2) => clsMathServise.Max(num1, num2);

        [HttpGet("MinNubers")]

        public int Min(double num1, int num2) => clsMathServise.Min(num1, num2);

        [HttpGet("FactorialNubers")]

        public int Factorial(double num1, int num2) => clsMathServise.Factorial(num1, num2);

    }
}
