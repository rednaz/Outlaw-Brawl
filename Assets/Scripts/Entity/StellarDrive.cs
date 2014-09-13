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
using System.Collections.Generic;
using System.Linq;
namespace Attacks
{
	public abstract class StellarDrive
	{
		protected int frames;
		protected List<string> commands;
		protected bool isAttacking = false;

		public bool attemptAttack (int currentFrames, string command, PlayerController player, PlayerController enemy)
		{
			if (!isAttacking && canAttack (currentFrames, command))
			{
				isAttacking = true;
				PlaySound();
			}
			if (isAttacking)
			{
				attack (player, enemy);

				if (endAttack (currentFrames))
					isAttacking = false;
			}

			return isAttacking;
		}

		protected bool canAttack (int currentFrames, string command)
		{
			if (commands.All(c => !Equals (c, command)))
				return false;

			return currentFrames >= frames;
		}
		
		protected bool endAttack (int currentFrames)
		{
			return currentFrames == 0;
		}

		void PlaySound ()
		{

		}

		abstract protected void attack (PlayerController player, PlayerController enemy);
	}
}