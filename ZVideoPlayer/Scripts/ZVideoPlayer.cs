/*
 **  ��Ƶ������ -- by JacobKay 20220323
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace ZTools
{
    [RequireComponent(typeof(ZVideoPlayerModel))]
    public class ZVideoPlayer : MonoBehaviour
    {
        ZVideoPlayerModel model;
        /// <summary>
        /// ��ǰ�������Ƿ��ڲ���
        /// </summary>
        public bool IsVideoPlaying
        {
            get { return model.IsVideoPlaying; }
        }
        /// <summary>
        /// ��ȡ��Ƶ����ʱ��
        /// </summary>
        public double PlayTime
        {
            set
            {
                model.PlayTime = value;
                if (!IsVideoPlaying)
                {
                    Play();
                }
            }
            get
            {
                return Mathf.Floor((float)model.PlayTime);
            }
        }
        /// <summary>
        /// ȫ��
        /// </summary>
        public bool FullScreen
        {
            set { model.FullScreen(value); }
        }
        /// <summary>
        /// ������Ƶurl
        /// </summary>
        public string VideoUrl
        {
            set { model.VideoSource(value); }
        }
        public int VideoVolum
        {
            set { model.VideoVolum = value; }
        }
        /// <summary>
        /// ������Ƶ��Դ��VideoClip
        /// </summary>
        public VideoClip VideoClip
        {
            set { model.VideoSource(value); }
        }
        private void Awake()
        {
            model = this.GetComponent<ZVideoPlayerModel>();
        }
        /// <summary>
        /// ������Ƶ����
        /// </summary>
        public void Play()
        {
            model.Play();
        }
        /// <summary>
        /// ������Ƶ��ͣ
        /// </summary>
        public void Pause()
        {
            model.Pause();
        }
        /// <summary>
        /// ������Ƶ��ͣ
        /// </summary>
        public void Stop()
        {
            model.Stop();
        }
    }
}
