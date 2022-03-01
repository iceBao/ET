using ET.EventType;

namespace ET
{
    public class InstallComputer_AddComponent:AEvent<EventType.InstallComputer>
    {
        protected async override ETTask Run(InstallComputer arg)
        {
            Computer computer = arg.Computer;

            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<KeyBoardComponent>();
            
            await ETTask.CompletedTask;
        }
    }
}