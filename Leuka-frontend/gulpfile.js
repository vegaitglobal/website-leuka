const gulp = require("gulp");
const pug = require("gulp-pug");
const concat = require("gulp-concat");
const sass = require("gulp-sass")(require("sass"));
const del = require("del");
const browserSync = require("browser-sync").create();

const { src, dest } = gulp;

gulp.task("build", (done) => {
  gulp.series(
    "clean",
    "scss",
    "pug"
  )(() => {
    browserSync.reload();
    done();
  });
});

gulp.task("pug", () => src("./src/*.pug").pipe(pug()).pipe(dest("./dist")));

gulp.task("scss", () =>
  src([ "./assets/styles/index.scss", "./partials/**/*.scss"])
    .pipe(sass({ outputStyle: "compressed" }).on("error", sass.logError))
    .pipe(concat("index.css"))
    .pipe(gulp.dest("./dist"))
);

gulp.task("watch", () => {
  browserSync.init({
    server: {
      baseDir: "./dist",
    },
  });

  gulp.watch(
    [
      "partials/*.scss",
      "partials/**/*.scss",
      "partials/**/*.html",
      "src/*.pug",
      "assets/styles/*.scss"
    ],
    gulp.series("build")
  );
});

gulp.task("clean", () => del("./dist/*"));
