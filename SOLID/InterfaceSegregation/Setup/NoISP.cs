namespace InterfaceSegregation.Setup
{
    public class NoISP
    {
        
    }

    public interface Workable
    {
        bool CanCode();
        string Code();
        bool Testing();
        bool Operations();
    }

    public class Developer : Workable
    {
        public bool CanCode()
        {
            return true;
        }

        public string Code() {
            return "Coding";
        }

        public bool Operations()
        {
            return false;
        }

        public bool Testing()
        {
            return false;
        }
    }

    public class TestEngineer : Workable
    {
        public bool CanCode()
        {
            return false;
        }

        public string Code()
        {
            throw new NotImplementedException();
        }
        public bool Operations()
        {
            return false;
        }

        public bool Testing()
        {
            return true;
        }
    }

      public class DevOps : Workable
    {
        public bool CanCode()
        {
            return false;
        }

        public string Code()
        {
            throw new NotImplementedException();
        }

        public bool Operations()
        {
            return true;
        }

        public bool Testing()
        {
            return true;
        }
    }
}