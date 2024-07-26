using NAudio.Wave;
using SoundTouch.Net.NAudioSupport;
using SoundTouch;
using ZombieShooter.Maps;
using NAudio.Wave.SampleProviders;

namespace ZombieShooter
{
    internal class Sounds
    {
        private static WaveOutEvent soundWaveOut;
        private static BlockAlignReductionStream CreateSoundStream(string filePath)
        {
            var soundStream = new BlockAlignReductionStream(new WaveFileReader(filePath));
            soundStream.Seek(0, SeekOrigin.Begin);
            return soundStream;
        }

        private static void PlaySound(string filePath, float volume = 0.05f)
        {
            var soundStream = CreateSoundStream(filePath);
            var soundWaveOut = new WaveOutEvent();

            var sampleProvider = new AudioFileReader(filePath);
            sampleProvider.Volume = volume;

            soundWaveOut.Init(sampleProvider);
            soundWaveOut.Play();
        }
        public static void NavigateMainMenuSound()
        {
            PlaySound("Sounds\\mainMenuNav.wav");
        }

        public static void NavigateMainMenuEnterSound()
        {
            PlaySound("Sounds\\mainMenuNavEnter.wav");
        }

        public static void NavigateMainMenuExitSound()
        {
            PlaySound("Sounds\\mainMenuNavExit.wav");
        }

        public static void NavigateMainMenuBackoutSound()
        {
            PlaySound("Sounds\\mainMenuNavBackout.wav");
        }

        public static void LobbyJoinSound()
        {
            PlaySound("Sounds\\mainMenuLobbyJoin.wav");
        }

        public static void ChangeScreenSound()
        {
            PlaySound("Sounds\\mainMenuChangeScreen.wav");
        }

        public static void PlayBackgroundMusic(string filePath, float volume = 0.2f)
        {
            StopBackgroundMusic();

            var audioFileReader = new AudioFileReader(filePath);
            audioFileReader.Volume = volume;

            var loopingStream = new LoopStream(audioFileReader);

            soundWaveOut = new WaveOutEvent();
            soundWaveOut.Init(loopingStream);
            soundWaveOut.Play();
        }

        public static void StopBackgroundMusic()
        {
            if (soundWaveOut != null && soundWaveOut.PlaybackState == PlaybackState.Playing)
            {
                soundWaveOut.Stop();
                soundWaveOut.Dispose();
                soundWaveOut = null;
            }
        }

        public static void PlayNukeSound()
        {
            PlaySound("Sounds\\nukeSound.wav");
        }

        public static void PlayNukeStartSound()
        {
            PlaySound("Sounds\\nukeLingerSound.wav");
        }

        public static void PlayNukeDieSound()
        {
            PlaySound("Sounds\\nukeDieSound.wav");
        }

        public static void PlayMaxAmmoSound()
        {
            PlaySound("Sounds\\maxAmmoSound.wav");
        }

        public static void PlayDoublePointsSound()
        {
            PlaySound("Sounds\\doublePointsSound.wav");
        }

        public static void PlayInstaKillSound()
        {
            PlaySound("Sounds\\instaKillSound.wav");
        }

        public static async void PlayInstaKillSoundLinger()
        {
            while (TestingMapForm.instaKillActive)
            {
                PlaySound("Sounds\\instaKillLingerSound.wav");
                await Task.Delay(1000);
            }
            Sounds.PlayInstaKillSoundOff();
        }





        // shooting sound
        public static void PlayM1911ShootSound()
        {
            PlaySound("Sounds\\m1911ShootSound.wav");
        }

        public static void PlayM14ShootSound()
        {
            PlaySound("Sounds\\m14ShootSound.wav");
        }

        
        
        
        // reload sound
        public static void PlayM14ReloadSound()
        {
            PlaySound("Sounds\\m14ReloadSound.wav");
        }
        public static void PlayM1911ReloadSound()
        {
            PlaySound("Sounds\\m1911ReloadSound.wav");
        }




        // speed cola reload sound

        public static void PlayM1911SpeedReloadSound()
        {
            PlaySound("Sounds\\m1911SpeedReloadSound.wav");
        }

        public static void PlayM14SpeedReloadSound()
        {
            PlaySound("Sounds\\m14SpeedReloadSound.wav");
        }










        public static void PlayInstaKillSoundOff()
        {
            PlaySound("Sounds\\instaKillDieSound.wav");
        }

        public static void PlayPowerUpPickUpSound()
        {
            PlaySound("Sounds\\powerUpPickUpSound.wav");
        }
        public static void PlayNoAmmoSound()
        {
            PlaySound("Sounds\\dryFireSound.wav");
        }

        public static void PlayMeleeSound()
        {
            Random rnd = new Random();
            int xd = rnd.Next(0, 6);
            switch (xd)
            {
                case 1:
                    PlaySound("Sounds\\swing_01.wav");
                    break;
                case 2:
                    PlaySound("Sounds\\swing_02.wav");
                    break;
                case 3:
                    PlaySound("Sounds\\swing_03.wav");
                    break;
                case 4:
                    PlaySound("Sounds\\swing_04.wav");
                    break;
                case 5:
                    PlaySound("Sounds\\swing_05.wav");
                    break;
                case 6:
                    PlaySound("Sounds\\swing_06.wav");
                    break;
                default:
                    break;
            }
        }

        public static void PlayWrongSound()
        {
            PlaySound("Sounds\\WrongSoundEffect.wav");
        }

        public static void PlayZombieDeathSound()
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(0, 12);

            switch (randomNumber)
            {
                case 1:
                    PlaySound("Sounds\\death_1.wav");
                    break;
                case 2:
                    PlaySound("Sounds\\death_2.wav");
                    break;
                case 3:
                    PlaySound("Sounds\\death_3.wav");
                    break;
                case 4:
                    PlaySound("Sounds\\death_4.wav");
                    break;
                case 5:
                    PlaySound("Sounds\\death_5.wav");
                    break;
                case 6:
                    PlaySound("Sounds\\death_6.wav");
                    break;
                case 7:
                    PlaySound("Sounds\\death_7.wav");
                    break;
                case 8:
                    PlaySound("Sounds\\death_8.wav");
                    break;
                case 9:
                    PlaySound("Sounds\\death_9.wav");
                    break;
                case 10:
                    PlaySound("Sounds\\death_10.wav");
                    break;
                case 11:
                    PlaySound("Sounds\\death_11.wav");
                    break;
                default:
                    PlaySound("Sounds\\death_1.wav");
                    break;
            }

        }
    }
}
