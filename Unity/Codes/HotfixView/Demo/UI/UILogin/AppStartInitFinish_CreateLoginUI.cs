

namespace ET
{
	public class AppStartInitFinish_RemoveLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override async ETTask Run(EventType.AppStartInitFinish args)
		{
			await UIHelper.Create(args.ZoneScene, UIType.UILogin);

			Computer computer = args.ZoneScene.AddChild<Computer>();

			Game.EventSystem.Publish(new EventType.InstallComputer() { Computer = computer });
			Game.EventSystem.PublishAsync(new EventType.InstallComputer() { Computer = computer });
			computer.Start();
			// computer.AddComponent<PCCaseComponent>();
			// computer.AddComponent<MonitorsComponent>();
			// computer.AddComponent<KeyBoardComponent>();
			//
			// computer.Start();
			// await TimerComponent.Instance.WaitAsync(3000);
			// computer.Dispose();
		}
	}
}
