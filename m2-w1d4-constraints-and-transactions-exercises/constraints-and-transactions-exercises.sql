-- Write queries to return the following:
-- The following changes are applied to the "pagila" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

--insert into actor(first_name, last_name)
--values('Hampton', 'Avenue')
--insert into actor(first_name, last_name)
--values('Lisa', 'Byway')



-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in 
-- ancient Greece", to the film table. The movie was released in 2008 in English. 
-- Since its an epic, the run length is 3hrs and 18mins. There are no special 
-- features, the film speaks for itself, and doesn't need any gimmicks.	
--select *
--from film

--insert into film( title, description, length, release_year, language_id, original_language_id)
--values( 'euclidean pi','The epic story of Euclid as a pizza delivery boy in 
---- ancient Greece' , 198, 2008, 1, 2 )

--select *
--from film
--where film.title = 'euclidean pi'

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly 
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

--insert into actor(first_name, last_name)
--values('Hampton', 'Avenue')
--insert into actor(first_name, last_name)
--values('Lisa', 'Byway')


-- 4. Add Mathmagical to the category table.

--insert into category(name)
--values('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI", 
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

select *
from film
where film.title = 'Euclidean pi' or  film.title = 'Egg igby' or  film.title = 'karate moon'
 or  film.title = 'random go' or  film.title = 'young language' 

update film_category set category_id = 19
from film_category 
join category on film_category.category_id = category.category_id
join film on film_category.film_id = film_category.film_id
where film.film_id = 274 or film.film_id = 494 or film.film_id = 714 
or film.film_id = 996 or film.film_id = 1003



-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films 
-- accordingly.
-- (5 rows affected)

-- 7. Add a copy of "Euclidean PI" to all the stores.

-- 8. The Feds have stepped in and have impounded all copies of the pirated film, 
-- "Euclidean PI". The film has been seized from all stores, and needs to be 
-- deleted from the film table. Delete "Euclidean PI" from the film table. 
-- (Did it succeed? Why?)

-- 9. Delete Mathmagical from the category table. 
-- (Did it succeed? Why?)

-- 10. Delete all links to Mathmagical in the film_category tale. 
-- (Did it succeed? Why?)

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI". 
-- (Did either deletes succeed? Why?)

-- 12. Check database metadata to determine all constraints of the film id, and 
-- describe any remaining adjustments needed before the film "Euclidean PI" can 
-- be removed from the film table.
