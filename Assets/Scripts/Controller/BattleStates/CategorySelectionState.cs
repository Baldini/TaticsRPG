using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategorySelectionState : BaseAbilityMenuState {
    public override void Enter () {
        base.Enter ();
        statPanelController.ShowPrimary (turn.actor.gameObject);
    }
    public override void Exit () {
        base.Exit ();
        statPanelController.HidePrimary ();
    }
    protected override void Cancel () {
        owner.ChangeState<CommandSelectionState> ();
    }

    protected override void Confirm () {
        switch (abilityMenuPanelController.selection) {
            case 0:
                Attack ();
                break;
            case 1:
                SetCategory (0);
                break;
            case 2:
                SetCategory (1);
                break;
        }
    }

    protected override void LoadMenu () {
        if (menuOptions == null) {
            menuTitle = "Action";
            menuOptions = new List<string> (3);
            menuOptions.Add ("Attack");
            menuOptions.Add ("White Magic");
            menuOptions.Add ("Black Magic");
        }

        abilityMenuPanelController.Show (menuTitle, menuOptions);
    }
    void Attack () {
        turn.ability = turn.actor.GetComponentInChildren<AbilityRange> ().gameObject;
        owner.ChangeState<AbilityTargetState> ();
    }
    void SetCategory (int index) {
        ActionSelectionState.category = index;
        owner.ChangeState<ActionSelectionState> ();
    }
}