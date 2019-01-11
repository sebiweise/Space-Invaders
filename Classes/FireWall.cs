using NetFwTypeLib;
using System;
using System.Security.Principal;

namespace Space_Invaders.Classes
{
    class FireWall
    {
        private INetFwPolicy2 _firewallPolicy;

        public FireWall()
        {
            _firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
        }

        public void addRule ()
        {
            bool isElevated = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            if (!RuleExists("Allow SpaceInvaders") && isElevated)
            {
                INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(
                Type.GetTypeFromProgID("HNetCfg.FWRule"));
                firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                firewallRule.Description = "";
                firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                firewallRule.Enabled = true;
                firewallRule.InterfaceTypes = "All";
                firewallRule.Name = "Allow SpaceInvaders";
                _firewallPolicy.Rules.Add(firewallRule);
            }
        }

        public void RemoveRule()
        {
            _firewallPolicy.Rules.Remove("Allow SpaceInvaders");
        }

        private bool RuleExists(string name)
        {
            foreach (INetFwRule rule in _firewallPolicy.Rules)
            {
                if(!string.IsNullOrEmpty(rule.Name) && rule.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
