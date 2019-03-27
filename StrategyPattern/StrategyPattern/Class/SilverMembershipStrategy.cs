using StrategyPattern.Interface;

namespace StrategyPattern.Class
{
    public class SilverMembershipStrategy : IMembershipStrategy
    {
        public int GetDiscount()
        {
            return 10;
        }
    }
}
