namespace LiskovSubstitution
{
    public class Smokes
    {
        public static void Run()
        {
            HealthyActivity healthyActivity = new HealthyActivity();
            healthyActivity.Enjoy();
            healthyActivity.FeelFresh();
            HealthyActivity smokingActivity = new SmokingActivity();
            smokingActivity.Enjoy();
            smokingActivity.FeelFresh();
        }
    }

    class HealthyActivity
    {
        public void Enjoy()
        {
            System.Console.WriteLine("I am enjoying this activity!!");
        }
        public virtual void FeelFresh()
        {
            System.Console.WriteLine("This activity is making me feel fresh!!");
        }
    }

    class SmokingActivity : HealthyActivity
    {
        public void Enjoy()
        {
            System.Console.WriteLine("I am enjoying this activity!!");
        }
        public override void FeelFresh()
        {
            throw new InvalidOperationException("Smoking doesn't make you feel fresh");
        }
    }

}