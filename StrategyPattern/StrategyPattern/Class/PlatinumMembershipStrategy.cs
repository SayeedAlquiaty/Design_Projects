using StrategyPattern.Interface;

namespace StrategyPattern.Class
{
    public class PlatinumMembershipStrategy : IMembershipStrategy
    {
        public int GetDiscount()
        {
            return 30;
        }
    }
}
