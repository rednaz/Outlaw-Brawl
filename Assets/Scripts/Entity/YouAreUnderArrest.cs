//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace Attacks
{
	public class YouAreUnderArrest : StellarDrive
	{
		public YouAreUnderArrest ()
		{
			this.frames = 100;
		}
		
		void attack (PlayerController p)
		{
			/*
			if( facingLeft == false )
			{
				rigidbody2D.AddForce ( new Vector2 ( 30 , 0 ) );
			}
			else
			{
				rigidbody2D.AddForce ( new Vector2 ( -30 , 0 ) );
			}*/
			
			if( frames % 10 == 0 )
			{
				p.amIgettingHitYAUA( 200, 0, 20, 2 );
			}
		}
	}
}