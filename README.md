# Gu.Wpf.AutoGrid

Small prototype for a less noisy WPF grid.

Sample xaml:

```xaml
<Window ...
        xmlns:autoRowGrid="http://gu.se/AutoRowGrid"
        ...>
    <autoRowGrid:Grid ColumnDefinitions="Auto * 50">
        <TextBlock Grid.Row="0" Grid.Column="0" Text="foo1" />
        <TextBox Grid.Row="0" Grid.Column="1" Text="bar1" />

        <TextBlock Grid.Row="1" Grid.Column="0" Text="foo2" />
        <TextBox Grid.Row="1" Grid.Column="1" Text="bar2" />
        
        <Rectangle Fill="Yellow" Height="15" Grid.Row="2" Grid.Column="0" Grid.ColumnSpan="3" />

        <autoRowGrid:Row>
            <TextBlock Grid.Column="0" Text="foo3" />
            <TextBox Grid.Column="1" Text="bar3" />
        </autoRowGrid:Row>

        <autoRowGrid:Row>
            <TextBlock Grid.Column="0" Text="foo4" />
            <TextBox Grid.Column="1" Text="bar4" />
        </autoRowGrid:Row>

        <Button Grid.Row="4" Grid.Column="2" Content="foo5" />

        <autoRowGrid:Row>
            <Rectangle Fill="Blue" Height="15" Grid.Row="2" Grid.Column="0" Grid.ColumnSpan="3" />
        </autoRowGrid:Row>
    </autoRowGrid:Grid>
</Window>
```

Produces:

![screenie](http://i.imgur.com/kAr50OX.png)