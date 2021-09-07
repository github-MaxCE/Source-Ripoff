// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""106afdbf-8167-40bd-be45-f69832a3ffb9"",
            ""actions"": [
                {
                    ""name"": ""Console"",
                    ""type"": ""Button"",
                    ""id"": ""b0ac7c9e-6e95-4e2f-9458-ed1451aa623a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3ab6ed47-1bca-49dc-99d9-d2882410ff5d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""f39eaa82-bf82-412e-a008-41ffa978cfc2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""98bb98df-3411-4601-9eb6-b630b3d3b5bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AltAttack"",
                    ""type"": ""Button"",
                    ""id"": ""3f0a466c-5648-41ff-962c-82c87b10d5ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""43acb1bd-dec2-4f50-883f-a8ab35542842"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6add1193-dbe5-464e-8e2f-5ae98fb15b45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""6db6692a-fa9a-474d-96e8-3b4752021d2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon1"",
                    ""type"": ""Button"",
                    ""id"": ""a7d27ed2-7bdb-4f36-98e0-ef15c4a4abe3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon2"",
                    ""type"": ""Button"",
                    ""id"": ""54e2f1be-284b-4c33-bb8e-2578fb910e84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon3"",
                    ""type"": ""Button"",
                    ""id"": ""e3a22d19-6014-4cda-8769-4ea13d9fa13a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon4"",
                    ""type"": ""Button"",
                    ""id"": ""9c04b88e-4576-4a0d-b186-dc9836a816a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon5"",
                    ""type"": ""Button"",
                    ""id"": ""f52dd472-657a-4262-8226-aa754a7ff6c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon6"",
                    ""type"": ""Button"",
                    ""id"": ""26cbf1a3-655a-430f-a04c-c45cc9e98713"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon7"",
                    ""type"": ""Button"",
                    ""id"": ""a339c2fa-c38a-4a80-a443-afb37b0ed7c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon8"",
                    ""type"": ""Button"",
                    ""id"": ""16d69680-6e70-4838-8dad-77c157ecfaf2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon9"",
                    ""type"": ""Button"",
                    ""id"": ""0f88c456-45ed-4400-809e-ccb2cb4cfeef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""56ca62bf-8420-4d91-9735-96f6e8174b23"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Console"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Move"",
                    ""id"": ""0e28fbbd-4d6a-49a1-9c2b-22771cee7087"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f4414186-3fcf-4878-a18a-31d7d1ebbb9a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0ef6aa3d-3445-4f7a-ae2e-4493a9f2f2e9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""16f14f62-965f-46b8-864c-25f101689fd8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b63e3e7d-39db-498f-a783-01a6b10bba32"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0cec51b2-90d2-4ef9-854e-3364a865cb24"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf2e9fa6-a3ca-4697-81df-84182f0e8293"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23372aa0-6f38-4d6a-b6ff-6fefd1994f51"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfb2c1ae-fade-41e5-bd47-072e833868fa"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4fc97be-466b-4662-8ab5-f02b1f7eb288"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""376d0445-000a-4086-bd14-79616ff9fbc6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03974f1e-9930-4147-9a10-58b6d14e542e"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a9f4b8a-b101-40a2-9067-43108be1c800"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa65cab6-8f23-4986-a064-fbb6af12a434"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31bf7417-2da7-4700-8b1b-1379c1b0af48"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""317a858f-095f-48de-aa51-3dd0533f279a"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31487797-6210-46b6-a21b-4185c1e0e7a7"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""684fdf91-2aae-4b76-9801-689e8d65a5f4"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4167c65a-8afc-42eb-a7f6-012b0a585198"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5052301a-9eeb-4fec-9dff-2379a97beb00"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""17d00437-f371-4bbd-9bf6-89bed0738ff6"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ad407fe7-a85c-4aeb-8e7b-b60b409dd3ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""12abcfbd-3fe8-4bbb-b6b3-43ff5a773936"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console"",
                    ""type"": ""Button"",
                    ""id"": ""805ba180-ddd9-4488-8f2f-8a07d42e6056"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""bb816977-262a-4b0f-923d-579125e2af65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""013e2a9e-7b5e-4969-abd6-bd1f01ed7e62"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2efc4ed5-a43d-4ca5-9e65-53c44a106270"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""036083cc-971a-4bd2-b2fd-f533c7a6d576"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38a0bd63-ca34-42aa-8ec7-eddbb7acbc4b"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2110d2f7-3d50-4256-a68d-b7f2a2b0ed02"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23cb9442-38b5-4d32-a8a4-6fcff16b1731"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d48b61df-c984-4ad2-bcb8-77b54057de05"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""336ec14b-58b9-4616-97b1-815c325f9835"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b239dd19-b218-43c4-afe0-b8d74567110b"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Console"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Console = m_Gameplay.FindAction("Console", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Mouse = m_Gameplay.FindAction("Mouse", throwIfNotFound: true);
        m_Gameplay_Attack = m_Gameplay.FindAction("Attack", throwIfNotFound: true);
        m_Gameplay_AltAttack = m_Gameplay.FindAction("AltAttack", throwIfNotFound: true);
        m_Gameplay_Use = m_Gameplay.FindAction("Use", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Weapon1 = m_Gameplay.FindAction("Weapon1", throwIfNotFound: true);
        m_Gameplay_Weapon2 = m_Gameplay.FindAction("Weapon2", throwIfNotFound: true);
        m_Gameplay_Weapon3 = m_Gameplay.FindAction("Weapon3", throwIfNotFound: true);
        m_Gameplay_Weapon4 = m_Gameplay.FindAction("Weapon4", throwIfNotFound: true);
        m_Gameplay_Weapon5 = m_Gameplay.FindAction("Weapon5", throwIfNotFound: true);
        m_Gameplay_Weapon6 = m_Gameplay.FindAction("Weapon6", throwIfNotFound: true);
        m_Gameplay_Weapon7 = m_Gameplay.FindAction("Weapon7", throwIfNotFound: true);
        m_Gameplay_Weapon8 = m_Gameplay.FindAction("Weapon8", throwIfNotFound: true);
        m_Gameplay_Weapon9 = m_Gameplay.FindAction("Weapon9", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Click = m_Menu.FindAction("Click", throwIfNotFound: true);
        m_Menu_Point = m_Menu.FindAction("Point", throwIfNotFound: true);
        m_Menu_Console = m_Menu.FindAction("Console", throwIfNotFound: true);
        m_Menu_Pause = m_Menu.FindAction("Pause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Console;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Mouse;
    private readonly InputAction m_Gameplay_Attack;
    private readonly InputAction m_Gameplay_AltAttack;
    private readonly InputAction m_Gameplay_Use;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Weapon1;
    private readonly InputAction m_Gameplay_Weapon2;
    private readonly InputAction m_Gameplay_Weapon3;
    private readonly InputAction m_Gameplay_Weapon4;
    private readonly InputAction m_Gameplay_Weapon5;
    private readonly InputAction m_Gameplay_Weapon6;
    private readonly InputAction m_Gameplay_Weapon7;
    private readonly InputAction m_Gameplay_Weapon8;
    private readonly InputAction m_Gameplay_Weapon9;
    public struct GameplayActions
    {
        private @Controls m_Wrapper;
        public GameplayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Console => m_Wrapper.m_Gameplay_Console;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Mouse => m_Wrapper.m_Gameplay_Mouse;
        public InputAction @Attack => m_Wrapper.m_Gameplay_Attack;
        public InputAction @AltAttack => m_Wrapper.m_Gameplay_AltAttack;
        public InputAction @Use => m_Wrapper.m_Gameplay_Use;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputAction @Weapon1 => m_Wrapper.m_Gameplay_Weapon1;
        public InputAction @Weapon2 => m_Wrapper.m_Gameplay_Weapon2;
        public InputAction @Weapon3 => m_Wrapper.m_Gameplay_Weapon3;
        public InputAction @Weapon4 => m_Wrapper.m_Gameplay_Weapon4;
        public InputAction @Weapon5 => m_Wrapper.m_Gameplay_Weapon5;
        public InputAction @Weapon6 => m_Wrapper.m_Gameplay_Weapon6;
        public InputAction @Weapon7 => m_Wrapper.m_Gameplay_Weapon7;
        public InputAction @Weapon8 => m_Wrapper.m_Gameplay_Weapon8;
        public InputAction @Weapon9 => m_Wrapper.m_Gameplay_Weapon9;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Console.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnConsole;
                @Console.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnConsole;
                @Console.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnConsole;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Mouse.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouse;
                @Attack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                @AltAttack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAltAttack;
                @AltAttack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAltAttack;
                @AltAttack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAltAttack;
                @Use.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Weapon1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon1;
                @Weapon1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon1;
                @Weapon1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon1;
                @Weapon2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon2;
                @Weapon2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon2;
                @Weapon2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon2;
                @Weapon3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon3;
                @Weapon3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon3;
                @Weapon3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon3;
                @Weapon4.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon4;
                @Weapon4.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon4;
                @Weapon4.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon4;
                @Weapon5.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon5;
                @Weapon5.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon5;
                @Weapon5.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon5;
                @Weapon6.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon6;
                @Weapon6.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon6;
                @Weapon6.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon6;
                @Weapon7.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon7;
                @Weapon7.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon7;
                @Weapon7.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon7;
                @Weapon8.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon8;
                @Weapon8.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon8;
                @Weapon8.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon8;
                @Weapon9.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon9;
                @Weapon9.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon9;
                @Weapon9.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWeapon9;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Console.started += instance.OnConsole;
                @Console.performed += instance.OnConsole;
                @Console.canceled += instance.OnConsole;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @AltAttack.started += instance.OnAltAttack;
                @AltAttack.performed += instance.OnAltAttack;
                @AltAttack.canceled += instance.OnAltAttack;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Weapon1.started += instance.OnWeapon1;
                @Weapon1.performed += instance.OnWeapon1;
                @Weapon1.canceled += instance.OnWeapon1;
                @Weapon2.started += instance.OnWeapon2;
                @Weapon2.performed += instance.OnWeapon2;
                @Weapon2.canceled += instance.OnWeapon2;
                @Weapon3.started += instance.OnWeapon3;
                @Weapon3.performed += instance.OnWeapon3;
                @Weapon3.canceled += instance.OnWeapon3;
                @Weapon4.started += instance.OnWeapon4;
                @Weapon4.performed += instance.OnWeapon4;
                @Weapon4.canceled += instance.OnWeapon4;
                @Weapon5.started += instance.OnWeapon5;
                @Weapon5.performed += instance.OnWeapon5;
                @Weapon5.canceled += instance.OnWeapon5;
                @Weapon6.started += instance.OnWeapon6;
                @Weapon6.performed += instance.OnWeapon6;
                @Weapon6.canceled += instance.OnWeapon6;
                @Weapon7.started += instance.OnWeapon7;
                @Weapon7.performed += instance.OnWeapon7;
                @Weapon7.canceled += instance.OnWeapon7;
                @Weapon8.started += instance.OnWeapon8;
                @Weapon8.performed += instance.OnWeapon8;
                @Weapon8.canceled += instance.OnWeapon8;
                @Weapon9.started += instance.OnWeapon9;
                @Weapon9.performed += instance.OnWeapon9;
                @Weapon9.canceled += instance.OnWeapon9;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Click;
    private readonly InputAction m_Menu_Point;
    private readonly InputAction m_Menu_Console;
    private readonly InputAction m_Menu_Pause;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Menu_Click;
        public InputAction @Point => m_Wrapper.m_Menu_Point;
        public InputAction @Console => m_Wrapper.m_Menu_Console;
        public InputAction @Pause => m_Wrapper.m_Menu_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                @Point.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPoint;
                @Console.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnConsole;
                @Console.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnConsole;
                @Console.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnConsole;
                @Pause.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Console.started += instance.OnConsole;
                @Console.performed += instance.OnConsole;
                @Console.canceled += instance.OnConsole;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IGameplayActions
    {
        void OnConsole(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnAltAttack(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnWeapon1(InputAction.CallbackContext context);
        void OnWeapon2(InputAction.CallbackContext context);
        void OnWeapon3(InputAction.CallbackContext context);
        void OnWeapon4(InputAction.CallbackContext context);
        void OnWeapon5(InputAction.CallbackContext context);
        void OnWeapon6(InputAction.CallbackContext context);
        void OnWeapon7(InputAction.CallbackContext context);
        void OnWeapon8(InputAction.CallbackContext context);
        void OnWeapon9(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnConsole(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
