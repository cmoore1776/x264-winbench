using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.VideoConverter;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace x264_winbench
{
    public partial class frmMain : Form
    {
        List<CancellationTokenSource> taskTokens;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        
        private async void btnStart_Click(object sender, EventArgs e)
        {
            Start();

            progBar.Invoke((MethodInvoker)delegate () { progBar.Value = 1; });
            var x = 0;
            foreach (var resolution in new string[] { "1280x720", "1920x1080" })
            {
                foreach (var framerate in new int[] { 30, 60 })
                {
                    x += 1;
                    bool shouldReturn = false;
                    if (resolution == "1280x720")
                    {
                        if (framerate == 30)
                        {
                            if (!cb720p30.Checked)
                            {
                                shouldReturn = true;
                            }
                        }
                        else
                        {
                            if (!cb720p60.Checked)
                            {
                                shouldReturn = true;
                            }
                        }
                    }
                    else
                    {
                        if (framerate == 30)
                        {
                            if (!cb1080p30.Checked)
                            {
                                shouldReturn = true;
                            }
                        }
                        else
                        {
                            if (!cb1080p60.Checked)
                            {
                                shouldReturn = true;
                            }
                        }
                    }

                    if (shouldReturn)
                    {
                        progBar.Invoke((MethodInvoker)delegate () { progBar.Value = (x * 8); });
                        goto NEXTFRAMERATE;
                    }

                    foreach (var preset in new string[] { "ultrafast", "superfast", "veryfast", "faster", "fast", "medium", "slow", "veryslow" })
                    {
                        if (btnStart.Enabled)
                        {
                            if (progBar.Value < progBar.Maximum)
                                progBar.Invoke((MethodInvoker)delegate () { progBar.Value += 1; });
                            goto NEXTPRESET;
                        }

                        lblStatus.Text = $"Testing {resolution.Split('x')[1]}p{framerate} @ {preset}...";

                        var Settings = new ConvertSettings
                        {
                            AudioCodec = "aac",
                            VideoCodec = "libx264",
                            VideoFrameRate = framerate,
                            VideoFrameSize = resolution,
                            CustomOutputArgs = $"-b:v 6000K -bufsize 6000K -preset {preset} -profile high -keyint_min 120 -pix_fmt yuv420p -threads 0"
                        };

                        var Converter = new FFMpegConverter();
                        //Converter.ConvertProgress += new EventHandler<ConvertProgressEventArgs>((x, y) => Converter_ConvertProgress(sender, y, preset));
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        await Task.Run(() => {
                            var taskToken = new CancellationTokenSource();
                            taskTokens.Add(taskToken);
                            Converter.ConvertProgress += new EventHandler<ConvertProgressEventArgs>((a, b) => Converter_ConvertProgress(a, b, taskToken));
                            Converter.ConvertMedia("skydiver_10sec.mp4", "mp4", Stream.Null, "mp4", Settings);
                        });
                        sw.Stop();
                        if (btnStop.Enabled)
                        {
                            if (progBar.Value < progBar.Maximum)
                                progBar.Invoke((MethodInvoker)delegate () { progBar.Value += 1; });

                            if (sw.Elapsed.TotalSeconds < 10)
                            {
                                if (resolution == "1920x1080")
                                    if (framerate == 60)
                                        clb1080p60.Invoke((MethodInvoker)delegate () { clb1080p60.SetItemChecked(clb1080p60.Items.IndexOf(preset), true); });
                                    else
                                        clb1080p30.Invoke((MethodInvoker)delegate () { clb1080p30.SetItemChecked(clb1080p30.Items.IndexOf(preset), true); });
                                else
                                    if (framerate == 60)
                                    clb720p60.Invoke((MethodInvoker)delegate () { clb720p60.SetItemChecked(clb720p60.Items.IndexOf(preset), true); });
                                else
                                    clb720p30.Invoke((MethodInvoker)delegate () { clb720p30.SetItemChecked(clb720p30.Items.IndexOf(preset), true); });
                            }
                            else
                            {
                                progBar.Invoke((MethodInvoker)delegate () { progBar.Value = (x * 8); });
                                break;
                            }
                        }
                        NEXTPRESET:;
                    }
                    NEXTFRAMERATE:;
                }
            }

            if (btnStop.Enabled)
            {
                Done();
            }
        }

        private void Converter_ConvertProgress(object sender, ConvertProgressEventArgs e, CancellationTokenSource taskToken)
        {
            if (taskToken.IsCancellationRequested)
            {
                ((FFMpegConverter)sender).Stop();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Aborted.";
            Stop();
        }

        private void Start()
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            cb720p30.AutoCheck = false;
            cb720p60.AutoCheck = false;
            cb1080p30.AutoCheck = false;
            cb1080p60.AutoCheck = false;
            for(var i = 0; i < 8; i++)
            {
                clb720p30.SetItemCheckState(i, CheckState.Unchecked);
                clb720p60.SetItemCheckState(i, CheckState.Unchecked);
                clb1080p30.SetItemCheckState(i, CheckState.Unchecked);
                clb1080p60.SetItemCheckState(i, CheckState.Unchecked);
            }
            taskTokens = new List<CancellationTokenSource>();
            lblStatus.Text = "Starting...";
        }

        private void Done()
        {
            lblStatus.Text = "Done.";
            Stop();
        }

        private void Stop()
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            cb720p30.AutoCheck = true;
            cb720p60.AutoCheck = true;
            cb1080p30.AutoCheck = true;
            cb1080p60.AutoCheck = true;
            taskTokens.ForEach((token) => { token.Cancel(); });
            progBar.Invoke((MethodInvoker)delegate () { progBar.Value = progBar.Maximum; });
        }

        private void cb720p30_CheckedChanged(object sender, EventArgs e)
        {
            clb720p30.Enabled = cb720p30.Checked;
        }

        private void cb720p60_CheckedChanged(object sender, EventArgs e)
        {
            clb720p60.Enabled = cb720p60.Checked;
        }

        private void cb1080p30_CheckedChanged(object sender, EventArgs e)
        {
            clb1080p30.Enabled = cb1080p30.Checked;
        }

        private void cb1080p60_CheckedChanged(object sender, EventArgs e)
        {
            clb1080p60.Enabled = cb1080p60.Checked;
        }
    }
}
