    using System;
using System.Windows.Forms;

namespace CarLibrary
{
	// Holds the state of the engine.
	public enum EngineState
	{
		engineAlive,
		engineDead
	}

	// Holds source of music.
	public enum MusicMedia
	{
		musicCd,
		musicTape,
		musicRadio,
        musicMp3
	}

	//The abstract base class for the hierarchy.
	public abstract class Car
	{
		// State data.
		protected string petName;
		protected short currSpeed;
		protected short maxSpeed;
		protected EngineState egnState = EngineState.engineAlive;

		// Ctors.
		public Car()
        {
            MessageBox.Show("Car 2.0.0.0");
        }
		public Car(string name, short max, short curr)
		{
            MessageBox.Show("Car 2.0.0.0");
			petName = name; maxSpeed = max; currSpeed = curr;
		}

		#region Properties 
		public string PetName
		{
			get { return petName; }
			set { petName = value; }
		}
		public short CurrSpeed
		{
			get { return currSpeed; }
			set { currSpeed = value; }
		}
		public short MaxSpeed
		{
			get { return maxSpeed; }
		}
	
		public EngineState EngineState
		{
			get { return egnState; }
		}
		#endregion

		// Abstract member.
		public abstract void TurboBoost();

		public void TurnOnRadio(bool musicOn, MusicMedia mm)
		{
            if (musicOn)
                MessageBox.Show(string.Format("Jamming {0}", mm.ToString()));
			else
				MessageBox.Show("Quiet time...");
		}
	}
}
