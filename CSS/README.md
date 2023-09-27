<details>
<summary>Basic set up</summary>

[Basic set up](https://youtu.be/wBKT2KN_Y9s)

```css
/* browser can change light/dark mode based on system preferences */
html {
  color-scheme: light dark;
}
/* font set up for whole site */
body {
  font-family: system-ui;
  font-size: 1.125rem;
  line-height: 1.5;
}
/* main - some wrapper */
main {
  /* sets width of whatever inside wrapper minimum of 70 characters or 100% - 4 rem */
  width: min(70ch, 100% - 4 rem);
  margin-inline: auto;
}
/* makes img, svg, video fit into page */
img, svg, video {
  max-width: 100%;
  display: block;
}
```
</details>

<details>
<summary>CSS units</summary>

When setting font sizes:

`em` - unit relative to font size of current element, better use `rem`.

`rem` - unit relative to font size of root element (constant throughout the document).

When setting width:

`%` - percent of parent element, better use `fr` instead or with combination with `fr`.

`fr` - unit, which represents a fraction of the leftover space in the grid container.

`ch` - relative to the width of the "0" (for example setting max width of paragraph to 70 characters).

`vw` - relative to 1% of the width of the viewport.

`vh` - relative to 1% of the height of the viewport.

`vmin` - relative to 1% of viewport's smaller dimension.

`vmax` - relative to 1% of viewport's larger dimension.

`px,cm,in,mm` - absolute units, don't use.

When setting height:

Just don't!
Set min height instead or don't do it at all.

When setting margin/padding:

Use `rem` or `em`.

[For reference](https://www.youtube.com/watch?v=N5wpD9Ov_To)

</details>

<details>
<summary>Simple design examples</summary>

```css
.cluster {
  display: flex;
  flex-wrap: wrap;
  gap: 1rem;
}
```
```css
.auto-grid {
  display: grid;
  gap: 1rem;
  grid-template-columns: repeat(auto-fit, minmax(min(10rem, 100%), 1fr));
}
```
```css
.flexible-grid {
  display: flex;
  flex-wrap: wrap;
  gap: 1rem;
}

.flexible-grid > * {
  flex: 1;
}
```
```css
.reel {
  --gap: 1rem;
  display: grid;
  gap: var(--gap);
  grid-auto-flow: column;
  grid-auto-columns: calc(50% - (var(--gap)/2));
  overflow-x: scroll;
  scroll-snap-type: x mandatory;
  scroll-padding: var(--gap);
}

.reel > * {
  scroll-snap-align: start;
}
```

</details>