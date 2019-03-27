using StrategyPattern.Enum;
using StrategyPattern.Interface;
using System.Collections.Generic;

namespace StrategyPattern.Class
{
    public class ImplementationContext
    {
        private static Dictionary<eMember, IMembershipStrategy> _strategies = new Dictionary<eMember, IMembershipStrategy>();

        static ImplementationContext()
        {
            _strategies.Add(eMember.Silver, new SilverMembershipStrategy());
            _strategies.Add(eMember.Gold, new GoldMembershipStrategy());
            _strategies.Add(eMember.Platinum, new PlatinumMembershipStrategy());
        }

        public static int GetDiscount(eMember member)
        {
            return _strategies[member].GetDiscount();
        }
    }
}
