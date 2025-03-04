﻿﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogamecheatsheet;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    List<BaseClass> entities = new List<BaseClass>();
    private BulletSystem bulletSystem;
    Texture2D bullet;
    

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        Texture2D pixel;
        Texture2D bullet;

        pixel = new Texture2D(GraphicsDevice,1,1);
        pixel.SetData(new Color[]{Color.White});

        bullet = Content.Load<Texture2D>("bullet");
        BulletSystem.CreateInstance(bullet);

        entities.Add(new Player(pixel));
        entities.Add(new Enemy(pixel, new Vector2(400,380)));
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        foreach(var entity in entities){
            entity.Update();
        }
        BulletSystem.Instance.Update();
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();

        foreach(var entity in entities){
            entity.Draw(_spriteBatch);
        }
        BulletSystem.Instance.Draw(_spriteBatch);

        _spriteBatch.End();
        base.Draw(gameTime);
    }
}
