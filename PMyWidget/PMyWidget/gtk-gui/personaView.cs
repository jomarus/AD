
// This file has been generated by the GUI designer. Do not modify.
namespace PMyWidget
{
	public partial class PersonaView
	{
		private global::Gtk.Table table1;
		private global::Gtk.Label apellidos;
		private global::Gtk.Entry entryApellidos;
		private global::Gtk.Entry entryNombre;
		private global::Gtk.Label nombre;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PMyWidget.PersonaView
			global::Stetic.BinContainer.Attach (this);
			this.Name = "PMyWidget.PersonaView";
			// Container child PMyWidget.PersonaView.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.apellidos = new global::Gtk.Label ();
			this.apellidos.Name = "apellidos";
			this.apellidos.LabelProp = global::Mono.Unix.Catalog.GetString ("Apellidos");
			this.table1.Add (this.apellidos);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.apellidos]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryApellidos = new global::Gtk.Entry ();
			this.entryApellidos.CanFocus = true;
			this.entryApellidos.Name = "entryApellidos";
			this.entryApellidos.IsEditable = true;
			this.entryApellidos.InvisibleChar = '•';
			this.table1.Add (this.entryApellidos);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryApellidos]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryNombre = new global::Gtk.Entry ();
			this.entryNombre.CanFocus = true;
			this.entryNombre.Name = "entryNombre";
			this.entryNombre.IsEditable = true;
			this.entryNombre.InvisibleChar = '•';
			this.table1.Add (this.entryNombre);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryNombre]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.nombre = new global::Gtk.Label ();
			this.nombre.Name = "nombre";
			this.nombre.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre");
			this.table1.Add (this.nombre);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.nombre]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
