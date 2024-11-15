//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""deea3047-b524-4c5b-85b7-e1cdda04c686"",
            ""actions"": [
                {
                    ""name"": ""Player1"",
                    ""type"": ""Button"",
                    ""id"": ""1c96c5d7-b1e3-4c45-a6c5-40903deb134a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2"",
                    ""type"": ""Button"",
                    ""id"": ""25e7c002-1f7b-49e8-93f0-668e0f2e192c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player3"",
                    ""type"": ""Button"",
                    ""id"": ""da0de4ef-8dd9-4cc8-8dc9-c85342d878c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player4"",
                    ""type"": ""Button"",
                    ""id"": ""ab74d5bb-878d-4a64-a094-0b64751490ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""18cf18d0-f53e-4d7f-9006-d1117aeac818"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38f1a504-9104-46d3-9f6e-2db679c6c9b5"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb2cda3d-5d0d-47d3-8101-a8c3d56a68b4"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31f9ba5c-d113-44f7-9882-0f577011670e"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player4"",
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
        m_Gameplay_Player1 = m_Gameplay.FindAction("Player1", throwIfNotFound: true);
        m_Gameplay_Player2 = m_Gameplay.FindAction("Player2", throwIfNotFound: true);
        m_Gameplay_Player3 = m_Gameplay.FindAction("Player3", throwIfNotFound: true);
        m_Gameplay_Player4 = m_Gameplay.FindAction("Player4", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Player1;
    private readonly InputAction m_Gameplay_Player2;
    private readonly InputAction m_Gameplay_Player3;
    private readonly InputAction m_Gameplay_Player4;
    public struct GameplayActions
    {
        private @Controls m_Wrapper;
        public GameplayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1 => m_Wrapper.m_Gameplay_Player1;
        public InputAction @Player2 => m_Wrapper.m_Gameplay_Player2;
        public InputAction @Player3 => m_Wrapper.m_Gameplay_Player3;
        public InputAction @Player4 => m_Wrapper.m_Gameplay_Player4;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Player1.started += instance.OnPlayer1;
            @Player1.performed += instance.OnPlayer1;
            @Player1.canceled += instance.OnPlayer1;
            @Player2.started += instance.OnPlayer2;
            @Player2.performed += instance.OnPlayer2;
            @Player2.canceled += instance.OnPlayer2;
            @Player3.started += instance.OnPlayer3;
            @Player3.performed += instance.OnPlayer3;
            @Player3.canceled += instance.OnPlayer3;
            @Player4.started += instance.OnPlayer4;
            @Player4.performed += instance.OnPlayer4;
            @Player4.canceled += instance.OnPlayer4;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Player1.started -= instance.OnPlayer1;
            @Player1.performed -= instance.OnPlayer1;
            @Player1.canceled -= instance.OnPlayer1;
            @Player2.started -= instance.OnPlayer2;
            @Player2.performed -= instance.OnPlayer2;
            @Player2.canceled -= instance.OnPlayer2;
            @Player3.started -= instance.OnPlayer3;
            @Player3.performed -= instance.OnPlayer3;
            @Player3.canceled -= instance.OnPlayer3;
            @Player4.started -= instance.OnPlayer4;
            @Player4.performed -= instance.OnPlayer4;
            @Player4.canceled -= instance.OnPlayer4;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnPlayer1(InputAction.CallbackContext context);
        void OnPlayer2(InputAction.CallbackContext context);
        void OnPlayer3(InputAction.CallbackContext context);
        void OnPlayer4(InputAction.CallbackContext context);
    }
}