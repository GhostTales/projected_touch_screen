using Godot;
using System;

public partial class task_adder : Panel
{
	[Export]
	PackedScene scene;
	[Export]
	Node column;
	[Export]
	LineEdit lineEdit;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_button_pressed()
	{
		column.AddChild(scene.Instantiate());

		if (lineEdit.Text != "")
			GD.PrintRich($"added [b]{scene.Instantiate().Name}[/b] to [b][hint=name = {lineEdit.Text}]{column.Name}[/hint][/b]");
		else
			GD.PrintRich($"added [b]{scene.Instantiate().Name}[/b] to [b]{column.Name}[/b]");

	}
}
