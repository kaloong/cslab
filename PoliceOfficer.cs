public class PoliceOfficer: PublicServant, IPerson
{
	private bool _hasEmergency; 

	public PoliceOfficer( string name, int age )
	{
		this.Name = name;
		this.Age  = age;
		//this._hasEmergency = false;
		_hasEmergency = false;
	}
	public string Name { get; set; }
	public int Age { get; set; }

	public override void DriveToPlaceOfInterest()
	{
		GetInPoliceCar();
		if (this.HasEmergency )
		//if (this._hasEmergency )
			TurnOnSiren();

		FollowDirections();
	}

	public bool HasEmergency
	{
		get { return _hasEmergency; }
		set { _hasEmergency = true; }
	}
	private void GetInPoliceCar() {}
	private void TurnOnSiren() {}
	private void FollowDirections() {}
}
