using _pull_BDD.Packages;
using System;
using TechTalk.SpecFlow;

namespace _pull_BDD.Feature
{
    [Binding]
    public class Feature1Steps
    {
        WebConnector connector = new WebConnector();
        [Given(@"I am Launching \$Pull")]
        public void GivenIAmLaunchingPull()
        {
            connector.OpenChromeBrowser();
            connector.NavigateURL("http://datingapp-dev-as.azurewebsites.net/");
        }
        
        [Then(@"I want to View all the users")]
        public void ThenIWantToViewAllTheUsers()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I Pull a user")]
        public void ThenIPullAUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I login using ""(.*)"" and ""(.*)""")]
        public void ThenILoginUsingAnd(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
