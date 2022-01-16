// GENERATED AUTOMATICALLY FROM 'Assets/Script/Player/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Bawah"",
            ""id"": ""8c8093a1-b6f1-41f0-83c1-24cc0d10e979"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c98989ec-5668-4120-970e-9fca6ff4ad35"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8af37773-44ee-471c-9c35-82648bb6bc65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""89db55c1-1e4c-4113-b59f-e9f22e14356c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""85c0aea1-5238-48ac-bf2a-8b80bc463511"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9035b956-c0e0-44e2-b9cc-9a5427875bef"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis Arrows"",
                    ""id"": ""b647adde-ddc5-4f2d-864e-594923671dd6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2ab36c13-82a8-4d0b-8d7f-2d5ab67a5cfb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8397966e-07dc-4baa-8282-3be3c75b3e7e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a1838c26-a193-4321-8640-4c257f0ca1e6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Bawah
        m_Bawah = asset.FindActionMap("Bawah", throwIfNotFound: true);
        m_Bawah_Move = m_Bawah.FindAction("Move", throwIfNotFound: true);
        m_Bawah_Jump = m_Bawah.FindAction("Jump", throwIfNotFound: true);
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

    // Bawah
    private readonly InputActionMap m_Bawah;
    private IBawahActions m_BawahActionsCallbackInterface;
    private readonly InputAction m_Bawah_Move;
    private readonly InputAction m_Bawah_Jump;
    public struct BawahActions
    {
        private @PlayerControl m_Wrapper;
        public BawahActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Bawah_Move;
        public InputAction @Jump => m_Wrapper.m_Bawah_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Bawah; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BawahActions set) { return set.Get(); }
        public void SetCallbacks(IBawahActions instance)
        {
            if (m_Wrapper.m_BawahActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BawahActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BawahActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BawahActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_BawahActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BawahActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BawahActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_BawahActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public BawahActions @Bawah => new BawahActions(this);
    public interface IBawahActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
