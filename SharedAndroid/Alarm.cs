﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObjects
{
    // Doing nothing Alarm
    // !!!! TODO find out how to make and alarm in Android
    // and implement it here 
    internal class Alarm
    {
        private System.Timers.Timer alarm;
        internal void InitAlarm()
        {
            alarm = new System.Timers.Timer();
            alarm.Elapsed += Alarm_Triggered;
        }
        internal void SetAlarm(TimeSpan AlarmTimeSpan)
        {
            alarm.Interval = AlarmTimeSpan.TotalMilliseconds;
            alarm.Start();
        }
        private void Alarm_Triggered(object sender, System.Timers.ElapsedEventArgs e)
        {
            alarm.Stop();
            try
            {
                //player = new System.Media.SoundPlayer();
                //player.SoundLocation = @"C:\Windows\Media\Alarm03.wav";
                //player.PlayLooping();
                //playing = true;
            }
            catch (Exception ex)
            {

            }
        }
        internal void StopAlarm()
        {
            //if (playing)
            //{
            //    player.Stop();
            //    playing = false;
            //}
            //else
            //{
            //    alarm.Stop();
            //    alarm.Dispose();
            //}
        }
    }
}
