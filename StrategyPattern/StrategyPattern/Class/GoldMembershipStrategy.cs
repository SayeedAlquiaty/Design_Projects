using StrategyPattern.Interface;

namespace StrategyPattern.Class
{
    public class GoldMembershipStrategy: IMembershipStrategy
    {
        public int GetDiscount()
        {
            return 20;
        }
    }
}
