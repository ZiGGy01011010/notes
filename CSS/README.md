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