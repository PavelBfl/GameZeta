using RevertedModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GameZeta.Components
{
	public class ComponentBase : Component, ITrackObject
	{
		public ComponentBase(TrackDispatcher trackDispatcher)
		{
			TrackDispatcher = trackDispatcher ?? throw new ArgumentNullException();
		}
		public ComponentBase()
			: this(TrackDispatcher.Default)
		{

		}

		public TrackDispatcher TrackDispatcher { get; } = null;
	}
}
