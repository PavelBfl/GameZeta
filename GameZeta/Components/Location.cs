using RevertedModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace GameZeta.Components
{
	public class Location : ComponentBase
	{
		public Location()
			: base()
		{
			
		}
		public Location(TrackDispatcher trackDispatcher)
			: base(trackDispatcher)
		{

		}

		public PointF Position { get => position.Value; set => position.Value = value; }
		private ITrackValue<PointF> position = null;
	}
}
