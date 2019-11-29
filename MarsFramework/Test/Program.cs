using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void EnterShareSkillDetails()
            {
                ShareSkill newShareskill = new ShareSkill();
                newShareskill.EnterShareSkill();
                //newShareskill.clickEvents();
               

            
            }
            [Test]
            public void EditShareSkillDetails()
            {
                ShareSkill newShareskill = new ShareSkill();
                newShareskill.EditShareSkill();
            }
            [Test]
            public void DeleteShareSkillDetails()
            {
                ShareSkill newShareskill = new ShareSkill();
                newShareskill.DeleteShareSkill();
            }

        }
    }
}