﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using GameEngine.MapChip;

namespace GameEngine
{
    public class MapChip_UpStream:GameObject,IMapChip//当たり判定があるMapChip
    {
        RectangleCollider rectangleCollider;
        public MapChip_UpStream(Transform transform):base("MapChip_UpStream", transform)
        {
            tag = "Map_UpStream";
            AddComponent(new SpriteRenderer("UpStream", transform, 4, Color.White, 1, 64));
            AddComponent(new RectangleCollider(this, new Square(transform, 64)));
            rectangleCollider = (RectangleCollider)GetComponent("RectangleCollider");
            rectangleCollider.isTrigger = true;
        }

        public override void Start()
        {
        }

        public override void Update()
        {

        }

        public override void Hit(RectangleCollider rectangleCollider)
        {
        }

        public override GameObject Clone()
        {
            GameObject clone = (GameObject)MemberwiseClone();
            clone.transform = transform.Clone();
            clone.gameCompoents = CloneComponets(clone);
            return clone;
        }

        public void Draw()
        {
            gameCompoents["SpriteRenderer"].Update();
        }
    }
}
