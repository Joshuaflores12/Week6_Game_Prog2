//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/inputsystem/Playerconrol.inputactions
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

public partial class @Playerconrol: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Playerconrol()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Playerconrol"",
    ""maps"": [
        {
            ""name"": ""player controls"",
            ""id"": ""41893099-0e5c-43f3-b791-7186d19a8f25"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""PassThrough"",
                    ""id"": ""16831726-176d-4080-9885-95dc19cce245"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""22dc83d1-9d05-49de-a590-fbc430cc244c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bda313c3-55df-46ae-a0f7-b22c47f78381"",
                    ""path"": ""W"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4b035ae9-e9d6-41c0-91e4-11541fc4af82"",
                    ""path"": ""S"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""83c23d17-f4ec-4bff-bf4c-bd7f4657d254"",
                    ""path"": ""A"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b7111f27-aed6-44da-9ed4-0a1d970a3faa"",
                    ""path"": ""D"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // player controls
        m_playercontrols = asset.FindActionMap("player controls", throwIfNotFound: true);
        m_playercontrols_WASD = m_playercontrols.FindAction("WASD", throwIfNotFound: true);
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

    // player controls
    private readonly InputActionMap m_playercontrols;
    private List<IPlayercontrolsActions> m_PlayercontrolsActionsCallbackInterfaces = new List<IPlayercontrolsActions>();
    private readonly InputAction m_playercontrols_WASD;
    public struct PlayercontrolsActions
    {
        private @Playerconrol m_Wrapper;
        public PlayercontrolsActions(@Playerconrol wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_playercontrols_WASD;
        public InputActionMap Get() { return m_Wrapper.m_playercontrols; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayercontrolsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayercontrolsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayercontrolsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayercontrolsActionsCallbackInterfaces.Add(instance);
            @WASD.started += instance.OnWASD;
            @WASD.performed += instance.OnWASD;
            @WASD.canceled += instance.OnWASD;
        }

        private void UnregisterCallbacks(IPlayercontrolsActions instance)
        {
            @WASD.started -= instance.OnWASD;
            @WASD.performed -= instance.OnWASD;
            @WASD.canceled -= instance.OnWASD;
        }

        public void RemoveCallbacks(IPlayercontrolsActions instance)
        {
            if (m_Wrapper.m_PlayercontrolsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayercontrolsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayercontrolsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayercontrolsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayercontrolsActions @playercontrols => new PlayercontrolsActions(this);
    public interface IPlayercontrolsActions
    {
        void OnWASD(InputAction.CallbackContext context);
    }
}